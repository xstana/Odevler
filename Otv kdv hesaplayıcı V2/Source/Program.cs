using System;
using System.Threading;

namespace otvhesap
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
            double aracfiyat = 0, OtvTutari = 0, KdvTutari = 0, DamgaVergisi = 0, ToplamVergi = 0;

            Console.Title = ("****  Vergi Hesaplayıcı V2 - Orkun ONUK  ****"); // Consolun adını değiştirdik

            // Kullanıcıdan aracın fiyat bilgisini alma / Double olarak aracfiyat değişkenine atama
            Console.ForegroundColor = ConsoleColor.Red;
            daktilo("Bu program aracınızın Otv, Kdv ve damga vergisini hesaplamak için ödev olarak hazırlanmıştır.",45);
            daktilo("....", 45);
            Console.Clear();
            Console.ResetColor();

            daktilo("Aracınızın satış fiyatını giriniz.\n>>",45);
            aracfiyat = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            //ÖTV %45, KDV %18 ve Damga Vergisi %1 olarak hesaplanacaktır.

            OtvTutari = (aracfiyat * 45) / 100; // Ötv Tutarını hesaplama
            KdvTutari = (aracfiyat * 18) / 100; // Kdv Tutarını hesaplama
            DamgaVergisi = (aracfiyat * 1) / 100; // Damga vergisini hesaplama
            ToplamVergi = (KdvTutari + OtvTutari + DamgaVergisi); // Toplam Vergi Tutarı


            // Çıktı
            Console.ForegroundColor = ConsoleColor.Red;
            daktilo(">Aracınızın ÖTV tutarı = "+OtvTutari+"TL \n", 35);
            daktilo(">Aracınızın KDV Tutarı ="+KdvTutari+"TL \n", 35);
            daktilo(">Aracınızın Damga Vergisi ="+DamgaVergisi+"TL \n", 35);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            daktilo("\n>"+aracfiyat+"TL Tutarındaki bir araca ödediğiniz toplam vergi " + ToplamVergi+"TL \n Çünkü Türkiyedesiniz.", 35);
            Console.ResetColor();

            Console.ReadKey();

            //Orkun Onuk 21908004
        }
    }
}