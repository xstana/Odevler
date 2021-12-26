using System;
using System.Threading;

namespace MtvHesap
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

        public static void Main()
        {



        Bas: // Geri Dönebilmek için programın başını belirttim 


            // Değişken Tanımlamaları
            int tipsecim = 0, yassecim = 0, hacimsecim = 0;
            double tutar = 0;


            Console.Title = ("****  Mtv Hesaplayıcı V2 - Orkun ONUK  ****"); // Consolun adını değiştirdik

            Console.ForegroundColor = ConsoleColor.Blue; // Yazı Rengini Değiştirmek için kullanıldı
            daktilo("MTV hesaplayıcıya hoş geldiniz.", 65); // daktilo efekti ile yazmak için üstte tanımladığımız fonksiyonu kullandık sondaki ,65 hızını belirtiyor.
            daktilo("...", 120);
            Console.ResetColor(); // Rengi sıfırlamak için kullandık


            //Araç Tipi seçimi - Seçimi okuma ve int32 olarak değişkene atadık
            Console.ForegroundColor = ConsoleColor.Red;
            daktilo("\n  \n Lüften Araç Tipinizi Seçiniz ; \n", 45);
            Console.ResetColor();
            daktilo(" -----\n" + " 1 - Binek Otomobil \n" + " 2 - Ticari Araç \n" + " ------\n" + " >>>  ", 15);
            tipsecim = Convert.ToInt32(Console.ReadLine());
            Console.Clear(); // Konsolu temizledik


            //Araç Yaşı seçimi - Seçimi  okuma ve int32 olarak değişkene atama
            Console.ForegroundColor = ConsoleColor.Red;
            daktilo("\n Yaş Seçimi Yapınız. ", 45);
            Console.ResetColor();
            daktilo("\n------\n" +
                "1 - 1 - 3 Yaş\n" +
                "2 - 4 - 7 Yaş\n" +
                "3 - 7 - 11 Yaş\n" +
                "4 - 11 Yaşından büyük\n " +
                "------\n" +
                ">>  ", 15);
            yassecim = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            // Hacim seçimi - Kullanıcı girdisini okuma ve int32 değişkene atama
            Console.ForegroundColor = ConsoleColor.Red;
            daktilo("Hacim Seçimi Yapınız. ", 45);
            Console.ResetColor();
            daktilo("\n ------\n" +
            "1 - 0-1300 cc arası\n" +
            "2 - 1301-1600 cc arası\n" +
            "3 - 1601-2000  cc arası\n" +
            "4 - 2001-2500  cc arası\n" +
            "5 - 2500 cc ve üzeri\n" +
            "------\n" +
            ">>  ", 15);
            hacimsecim = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


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
                Console.WriteLine("HATA\n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                daktilo("Yanlış bir tip seçimi yaptınız. \n " +
                    "\nYeniden seçim yapmanız için yönlendiriliyorsunuz", 45);
                daktilo("..... ", 700);
                Console.ResetColor();
                Console.Clear();


                goto Bas; // Üstte bas şeklinde tanımladığımız kodun en başına yönlendirdik
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
                Console.WriteLine("HATA!\n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                daktilo("Yanlış bir yaş seçimi yaptınız. \n " +
                    "\nYeniden seçim yapmanız için yönlendiriliyorsunuz", 45);
                daktilo("..... ", 700);
                Console.ResetColor();

                Console.Clear();
                goto Bas;
            }

            // Seçilen hacim aralığına göre switch karar yapısı
            switch (hacimsecim)
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
                    Console.WriteLine("HATA! \n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    daktilo("Yanlış bir hacim seçimi yaptınız. \n " +
                        "\nYeniden seçim yapmanız için yönlendiriliyorsunuz", 45);
                    daktilo("..... ", 700);
                    Console.ResetColor();
                    Console.Clear();
                    goto Bas;
                    break;
            }

            // Hesaplama sonuç çıktısı
            Console.ForegroundColor = ConsoleColor.Blue;
            daktilo("Ödemeniz gereken toplam  vergi tutarı: " + tutar + "TL'dir", 45);  // İndisler fonksiyonda hata verdiği için bu şekilde yazmak zorundayız
            Console.ResetColor();



            // Araç bilgilerini yazdırma
            Console.ForegroundColor = ConsoleColor.Yellow;
            daktilo(" \n \n>> Araç Bilgileriniz: ", 45);
            Console.ResetColor();

            switch (tipsecim)
            {
                case 1:
                    daktilo("\n> Araç Tipiniz : Binek Otomobil ", 15);
                    break;
                case 2:
                    daktilo("\n> Araç Tipiniz : Ticari Araç", 15);
                    break;
                default:
                    daktilo("NULL", 15);
                    break;
            }

            switch (yassecim)
            {
                case 1:
                    daktilo("\n> Araç Yaşınız : 1 ile 3 yaş arası ", 15);
                    break;
                case 2:
                    daktilo("\n> Araç Yaşınız : 4 ile 7 yaş arası", 15);
                    break;
                case 3:
                    daktilo("\n> Araç Yaşınız : 7 ile 11 yaş arası ", 15);
                    break;
                case 4:
                    daktilo("\n> Araç Yaşınız : 11 yaşından büyük", 15);
                    break;
                default:
                    daktilo("NULL", 15);
                    break;

            }

            switch (hacimsecim)
            {
                case 1:
                    daktilo("\n> Araç Hacminiz : 0-1300cc arası ", 15);
                    break;
                case 2:
                    daktilo("\n> Araç Hacminiz : 1301-1600cc arası", 15);
                    break;
                case 3:
                    daktilo("\n> Araç Hacminiz : 1601-2000cc arası", 15);
                    break;
                  case 4:
                    daktilo("\n> Araç Hacminiz : 2001-2500cc arası ", 15);
                    break;
                case 5:
                    daktilo("\n> Araç Hacminiz : 2500cc ve üzeri", 15);
                    break;
                default:
                    daktilo("NULL",15);
                    break;
            }


               Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n \n \n \n                             Türkiye serverında bol şans..."); // Teselli
            Console.ResetColor();


            // Bitiş
            Console.ReadKey();
        }
    }         // Orkun ONUK 21908004
}
