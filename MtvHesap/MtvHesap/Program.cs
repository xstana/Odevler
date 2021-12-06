using System;

namespace MtvHesap
{
    class Program
    {
        static void Main(string[] args)

        {

        Bas:
            int tipsecim = 0, yassecim = 0, hacimsecim = 0;
            double tutar = 0;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("MTV hesaplayıcıya hoş geldiniz.");
            Console.ResetColor();

            //Araç Tipi seçimi - Seçimi okuma ve int32 olarak değişkene atama
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n  \n Lüften Araç Tipinizi Seçiniz ; \n");
            Console.ResetColor();
              Console.WriteLine("-----\n" +
                "1 - Binek Otomobil \n" +
                "2 - Ticari Araç \n" +
                "------\n" +
                "Seçim yapınız (1-2) ;\n");
            tipsecim = Convert.ToInt32(Console.ReadLine());


            //   //Araç Yaşı seçimi - Seçimi  okuma ve int32 olarak değişkene atama
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Yaş Seçimi Yapınız. ");
            Console.ResetColor();
            Console.WriteLine("\n------\n" +
                "1 - 1 - 3 Yaş\n" +
                "2 - 4 - 7 Yaş\n" +
                "3 - 7 - 11 Yaş\n" +
                "4 - 11 Yaşından büyük\n " +
                "------\n" +
                "Seçim Yapınız (1-2-3-4)\n");
            yassecim = Convert.ToInt32(Console.ReadLine());


            // Hacim seçimi - Kullanıcı girdisini okuma ve int32 değişkene atama
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hacim Seçimi Yapınız. ");
            Console.ResetColor();
                Console.WriteLine("\n ------\n" +
                "1 - 0-1300 cc arası\n" +
                "2 - 1301-1600 cc arası\n" +
                "3 - 1601-2000  cc arası\n" +
                "4 - 2001-2500  cc arası\n" +
                "5 - 2500 cc ve üzeri\n" +
                "------\n" +
                "Seçim Yapınız (1-2-3-4-5)\n");
            hacimsecim = Convert.ToInt32(Console.ReadLine());


            //  Kullanıcıdan alınan tipsecim değişkenindeki veriye göre if karar yapısı

            if (tipsecim == 1) // Binek araçlar 150TL'den hesaplanacak
            {
                tutar = 150;
            }
            else if (tipsecim == 2) // Ticari araçlar 225TL'den hesaplanacak
            {
                tutar = 225;
            }

            else // 2 seçeneğinde gerçekleşmediği durumda hata vermemesi
                //için kullanıcının uyarılması ve goto ile başa gönderilmesi
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("HATA!");
                Console.ResetColor();
                Console.WriteLine("Yanlış bir tip seçimi yaptınız. \n " +
                    "Yeniden seçim yapmanız için yönlendiriliyorsunuz...");
              
                goto Bas;
            }


            // Aracın yaşına göre çarpılacak değerin if karar yapısı ile belirlenmesi

            if (yassecim == 1)
            {
                tutar = tutar * 1.80; // yaşın 1-3 aralığında olduğu durum
            }
            else if (yassecim == 2)
            {
                tutar = tutar * 1.60; // yaşın 4-7 aralığında olduğu durum
            }
            else if (yassecim == 3)
            {
                tutar = tutar * 1.40; // yaşın 7-11 aralığında olduğu durum
            }
            else if (yassecim == 4)
            {
                tutar = tutar * 1.15; // yaşın 11+ olduğu durum
            }

            else
            { // Yine aralık dışı seçimde karşılaşılacak hata mesajı ve goto etiketi
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("HATA!");
                Console.ResetColor();
                Console.WriteLine("Yanlış bir yaş seçimi yaptınız. \n " +
       "Yeniden seçim yapmanız için yönlendiriliyorsunuz...");
                goto Bas;
            }

            // Seçilen hacim aralığına göre switch karar yapısı
            switch(hacimsecim)
                {
                case 1:
                    tutar = tutar * 2; // 0-1300 aralığındaki hacim
                    break;
                case 2:
                    tutar = tutar * 3; // 1301-1600 aralığındaki hacim
                    break;
                case 3:
                    tutar = tutar * 4; // 1601-2000 aralığındaki hacim
                    break;
                case 4:
                    tutar = tutar * 5; // 2001-2500 aralığındaki hacim
                    break;
                case 5:
                    tutar = tutar * 6; //2500+ hacim
                    break;

                default: // 5 durum dışında seçilen değerler için varsayılan durum olarak hata mesajı
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("HATA!");
                    Console.ResetColor();
                    Console.WriteLine("Yanlış bir hacim seçimi yaptınız. \n " +
           "Yeniden seçim yapmanız için yönlendiriliyorsunuz...");
                    goto Bas;
            }
            
            // Hesaplama sonuç çıktısı
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n------\n" +
                "Ödemeniz gereken toplam toplam vergi tutarı {0}TL'dir.\n",tutar);
         Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n \nTürkiye serverında bol şans..."); // Teselli
            Console.ResetColor();

            // Bitiş
            Console.ReadKey();  
        }
    }         // Orkun ONUK 21908004
}
