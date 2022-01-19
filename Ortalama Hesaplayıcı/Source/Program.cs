using System;
using System.Threading;
namespace Kapadokya_Not_Hesaplama
{
	class Program
	{
		public static void daktilo(string message, int speed)


		// Daktilo yazı efekti için fonksiyon tanımlaması
		{
			for (int i = 0; i < message.Length; i++)
			{
				Console.Write(message[i]);
				Thread.Sleep(speed);
			}
		}
		static void Main(string[] args)
		{
			double y_v1, y_v2, y_o1, y_o2, y_f;
			double v1 = 0, v2 = 0, o1 = 0, o2 = 0, f = 0, sonuc;

			bas:
			Console.Title = ("Not Hesaplama");
			daktilo("Kapadokya Üniversitesi Not Hesaplama Aracına hoş geldiniz. \n \n", 35);
			daktilo("Yüzdelik olarak notlandırma oranlarınızı giriniz ; \n" +
				"Eğer belirtilen notlama bölümünüz için geçerli değilse değeri '0' olarak giriniz.\n\n", 35);

			daktilo("Vize 1 >> %", 25);
			y_v1 = Convert.ToDouble(Console.ReadLine());

			daktilo("Vize 2 >> %", 25);
			y_v2 = Convert.ToDouble(Console.ReadLine());

			daktilo("Ödev 1 >> %", 25);
			y_o1 = Convert.ToDouble(Console.ReadLine());

			daktilo("Ödev 2 >> %", 25);
			y_o2 = Convert.ToDouble(Console.ReadLine());

			daktilo("Final >> %", 25);
			y_f = Convert.ToDouble(Console.ReadLine());

			not:

			if (y_v1 > 0)
			{
				Console.Clear();
				daktilo("İlk vizenizin notunuzu giriniz >> ", 25);
				v1 = Convert.ToDouble(Console.ReadLine());
				v1 = ((v1 * y_v1) / 100);
			}
			if (y_v2 > 0)
			{
				Console.Clear();
				daktilo("2. vizenizin notunuzu giriniz >> ", 25);
				v2 = Convert.ToDouble(Console.ReadLine());
				v2 = ((v2 * y_v2) / 100);
			}
			if (y_o1 > 0)
			{
				Console.Clear();
				daktilo("İlk ödevinizin notunuzu giriniz >> ", 25);
				o1 = Convert.ToDouble(Console.ReadLine());
				o1 = ((o1 * y_o1) / 100);
			}
			if (y_o2 > 0)
			{
				Console.Clear();
				daktilo("2. ödevinizin notunuzu giriniz >> ", 25);
				o2 = Convert.ToDouble(Console.ReadLine());
				o2 = ((o2 * y_o2) / 100);
			}
			if (y_f > 0)
			{
				Console.Clear();
				daktilo("Final notunuzu giriniz >> ", 25);
				f = Convert.ToDouble(Console.ReadLine());
				f = ((f * y_f) / 100);
			}
			Console.Clear();
			sonuc = (v1 + v2 + o1 + o2 + f);

			if (sonuc > 90)
			{
				daktilo("Ders Ortalamanız >> " + sonuc, 45);
				daktilo("\nHarf Notunuz >> AA", 45);
				Console.ForegroundColor = ConsoleColor.Green;
				daktilo("\nBaşarı Durumunuz >> Başarılı", 85);

			}
			else if (sonuc > 85)
			{
				daktilo("Ders Ortalamanız >> " + sonuc, 45);
				daktilo("\nHarf Notunuz >> BA", 45);
				Console.ForegroundColor = ConsoleColor.Green;
				daktilo("\nBaşarı Durumunuz >> Başarılı", 85);
			}
			else if (sonuc > 75)
			{
				daktilo("Ders Ortalamanız >> " + sonuc, 45);
				daktilo("\nHarf Notunuz >> BB", 45);
				Console.ForegroundColor = ConsoleColor.Green;
				daktilo("\nBaşarı Durumunuz >> Başarılı", 85);
			}
			else if (sonuc > 70)
			{
				daktilo("Ders Ortalamanız >> " + sonuc, 45);
				daktilo("\nHarf Notunuz >> CB", 45);
				Console.ForegroundColor = ConsoleColor.Green;
				daktilo("\nBaşarı Durumunuz >> Başarılı", 85);
			}
			else if (sonuc > 60)
			{
				daktilo("Ders Ortalamanız >> " + sonuc, 45);
				daktilo("\nHarf Notunuz >> CC", 45);
				Console.ForegroundColor = ConsoleColor.Green;
				daktilo("\nBaşarı Durumunuz >> Başarılı", 85);

			}
			else if (sonuc > 55)
			{
				daktilo("Ders Ortalamanız >> " + sonuc, 45);
				daktilo("\nHarf Notunuz >> DC", 45);
				Console.ForegroundColor = ConsoleColor.Yellow;
				daktilo("\nBaşarı Durumunuz >> Koşullu Başarılı", 85);
			}
			else if (sonuc > 45)
			{
				daktilo("Ders Ortalamanız >> " + sonuc, 45);
				daktilo("\nHarf Notunuz >> DD", 45);
				Console.ForegroundColor = ConsoleColor.Yellow;
				daktilo("\nBaşarı Durumunuz >> Koşullu Başarılı", 85);
			}
			else if (sonuc > 40)
			{
				daktilo("Ders Ortalamanız >> " + sonuc, 45);
				daktilo("\nHarf Notunuz >> FD", 45);
				Console.ForegroundColor = ConsoleColor.Red;
				daktilo("\nBaşarı Durumunuz >> Başarısız", 85);
			}
			else if (sonuc > 1)
			{
				daktilo("Ders Ortalamanız >> " + sonuc, 45);
				daktilo("\nHarf Notunuz >> FF", 45);
				Console.ForegroundColor = ConsoleColor.Red;
				daktilo("\nBaşarı Durumunuz >> Başarısız", 85);

		
			}

			secimm:
			Console.ResetColor();
			daktilo("\n......", 100);
			daktilo("\nYeniden hesaplama yapmak için 1' i " +
				"\nYeniden oran girerek hesaplama yapmak için 2'yi" +
				"\nÇıkış Yapmak için 0'ı tuşlayın. \n>> ", 35);
			Int16 secim1 = Convert.ToInt16(Console.ReadLine());

			switch (secim1)
			{

				case 1:
					{
						Console.Clear();
						Console.ForegroundColor = ConsoleColor.Blue;
						daktilo("Hesaplama yapmak için yönlendiriliyorsunuz", 25);
						daktilo("...", 300);
						Console.ResetColor();
						goto not;
						break;
					}

				case 2:
					{
						Console.Clear();
						Console.ForegroundColor = ConsoleColor.Blue;
						daktilo("Hesaplama yapmak için en başa yönlendiriliyorsunuz", 25);
						daktilo("...", 300);
						Console.ResetColor();
						goto bas;
						break;
					}
				case 0:
					{
						Console.Clear();
						Console.ForegroundColor = ConsoleColor.Blue;
						daktilo("Uygulamamızı kullandığınız için teşekküler çıkış yapılıyor.", 25);
						daktilo(".....", 400);
						Console.Clear();
						Console.ResetColor();
						Environment.ExitCode = -1;
						break;
					}
				default:
					{
						Console.Clear();
						Console.ForegroundColor = ConsoleColor.Red;
						daktilo("Yanlış bir seçim yaptınız yeniden seçim yapmak için yönlendiriliyorsunuz", 25);
						daktilo(".....", 400);
						Console.ResetColor();
						goto secimm;
						break;
					}

			}


		}
	}
}
