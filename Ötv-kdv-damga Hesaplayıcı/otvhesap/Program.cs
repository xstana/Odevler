using System;

namespace otvhesap
{
    class Program
    {
        static void Main(string[] args)
        {
            double aracfiyat = 0, OtvTutari = 0, KdvTutari = 0, DamgaVergisi = 0, ToplamVergi = 0;

            // Kullanıcıdan aracın fiyat bilgisini alma / Double olarak aracfiyat değişkenine atama
            Console.WriteLine("Aracınızın satış fiyatını giriniz. ");
            aracfiyat = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
            //ÖTV %45, KDV %18 ve Damga Vergisi %1 olarak hesaplanacaktır.

            OtvTutari = (aracfiyat * 45) /100 ; // Ötv Tutarını hesaplama
            KdvTutari = (aracfiyat * 18) / 100; // Kdv Tutarını hesaplama
            DamgaVergisi = (aracfiyat * 1) /100; // Damga vergisini hesaplama
            ToplamVergi = (KdvTutari + OtvTutari + DamgaVergisi); // Toplam Vergi Tutarı


            // Çıktı
            Console.WriteLine("Aracınızın ÖTV tutarı = {0}TL \n" +
                "Aracınızın KDV Tutarı ={1}TL \n" +
                "Aracınızın Damga Vergisi = {2}TL \n" +
                "\n {3}TL Tutarındaki bir araca ödediğiniz toplam vergi {4}TL \n Çünkü Türkiyedesiniz.", 
                OtvTutari,KdvTutari,DamgaVergisi,aracfiyat,ToplamVergi);


            Console.ReadKey();

                                       //Orkun Onuk 21908004
        }
    }
}
