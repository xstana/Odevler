using System;
using System.Threading;
namespace UcgenHesaplayıcı
{
    class Program
    {
        public static void daktilo(string message, int speed)


        // Daktilo yazı efekti vermek için fonksiyon tanımlaması yapıldı daha sonra kullanırken açıklayacağım
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(speed);
            }
        }
        static void Main(string[] args)
        {
        bas:
            double k1 = 0, k2 = 0, k3 = 0, s = 0, alan = 0, secim = 0;
            // Değişkenlerin Tanımlanması

            Console.ForegroundColor = ConsoleColor.Red;
            daktilo("Bu program çeşitkenar üçgenin alanını hesaplamak için hazırlanmıştır", 45);
            daktilo("....", 1000);
            Console.Clear();
            Console.ResetColor();

            // Kenarların Girişi
            daktilo("1. Kenarı Giriniz\n>> ", 45);
            k1 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            daktilo("2. Kenarı Giriniz\n>> ", 45);
            k2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            daktilo("3. Kenarı Giriniz\n>> ", 45);
            k3 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();


            s = (k1 + k2 + k3) / 2;
            // Üçgenin çevre uzunluğunun yarısı

            alan = Math.Sqrt(s * (s - k1) * (s - k2) * (s - k3));
            // Alan hesaplama için gerekli formül                                    
            // Kaynak https://suleymancalin.com/hesapla/cesitkenar-

            Console.ForegroundColor = ConsoleColor.Red;
            daktilo("> Üçgeninizin çevresi " + (s * 2) + " birimdir.", 45);
            daktilo("\n> Üçgeninizin alanı " + alan + " birimdir.", 45);
            daktilo("\n \n>> Kenar Uzunluklarınız \n" + k1 + "\n" + k2+ "\n" + k3 + "\n",45);
            Console.ResetColor();


        secim: // Yeniden hesaplama yapılmak istenirse
               // Açıkcası sıkıldım ve yeni bir şeyler denemek istedim
            Console.ForegroundColor = ConsoleColor.Green;
            daktilo("\n\n Yeni bir hesaplama yapmak için 1'i \nÇıkış yapmak için 0'ı tuşlayın\n >> ", 45);
            secim = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.Clear();
            if (secim == 1)
            { goto bas; }
            else if (secim == 0)
            { // 0 seçildiğinde 2 saniye bekleyip çıkış yapıyor
                Console.ForegroundColor = ConsoleColor.Yellow;
                daktilo(" Programı Kullandığınız için teşekkürler", 35);
                daktilo("....", 2000);
                Console.ResetColor();
                Environment.Exit(0);
            }
            else
            { // Yanlış tuşlamada tekrar seçtiriyor
                daktilo("Yanlış bir tuşlama yaptınız\n Yeniden yönlendiriliyorsunuz", 35);
                daktilo("....", 2000);
                goto secim;
            }
        }
    }
}