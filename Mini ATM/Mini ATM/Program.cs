using System;
using Authenty;

namespace Mini_ATM
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int Balance = 1000;  // Balance Adıyla int32 bakiye değeri

            Menu: // Menü bölümü daha sonra buraya dönmek için Go to operatörü kullanılacak

                    // Ana Menü
                    Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("**** Mini ATM'ye Hoş geldiniz! ****"); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n \n \n Para yatırma için 1'yi Tuşlayınız. \n Para çekmek için 2'yi tuşlayınız. \n Çıkış yapmak için 0'ı tuşlayınız  "); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n \n \n Güncel Bakiyeniz = " + Balance + "\n"); Console.ResetColor();
                SByte secim = Convert.ToSByte(Console.ReadLine());

            // Console.ForegroundColor kodu consol'a yazdırdığımız yazıyı renklendirmek için kullanılıyor
            // Console.ResetColor ise rengin bittiği yeri belirtmek için var


            // Kullanıcının 1'i tuşlaması durumu
            if (secim == 1)
            {
               
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Lütfen Yatıracağınız Tutarı Giriniz..."); Console.ResetColor();
                int tutar = Convert.ToInt32(Console.ReadLine());
                Balance = Balance + tutar;
                Console.WriteLine("\n Para yatırma işleminiz gerçekleştirildi! Yatırılan Tutar = " + tutar);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n \n Güncel Bakiyeniz = " + Balance); Console.ResetColor();
            }

            // Kullanıcının 2'Yi tuşlaması durumu
            if (secim == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Lütfen Çekeceğiniz Giriniz..."); Console.ResetColor();
                int tutar = Convert.ToInt32(Console.ReadLine());
                Balance = Balance - tutar;
                Console.WriteLine("\n Para yatırma çekme işleminiz gerçekleştirildi! Çektiğiniz Tutar = " + tutar);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n \n Güncel Bakiyeniz = " + Balance); Console.ResetColor();
                goto tuslama1; // Burdaki goto etiketi kullanıcının sonraki işlemini yapabilmesi için
                               // bir aşağıdaki kodda olan tuslama1 başlığına yönlendiriyor
            }
        tuslama1: // Ahada burdaki etikete geliyoruz 
            // Kullanıcı her hangi bir işlemden sonra tuşlama yapması için buraya yönlendiriliyor ki 
            // İşleme devam edebilsin
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Ana menüye dönmek için 1'i Tuşlayınız.  \n Çıkış yapmak için 0'ı Tuşlayınız");
                secim = Convert.ToSByte(Console.ReadLine());


            // Kullanıcı 1' i seçerse menüye tekrar yönlendiriliyor böylece program döngüye girmiş oluyor
                if (secim == 1)
                { goto Menu; }


                // burdada pezonun sıkılıp 0'ı tuşladığı ve çıkış yaptığı bölüm var
                // napim zorla mı tutim
                if (secim ==0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" \n \n**** Mini ATM'yi kullandığınız için teşekkürler! ****"); Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" \n \n \n Bu proje Orkun Onuk tarafından aşırı can sıkıntısı sebebi ile kodlanmıştır kendinize iyi bakın :,)"); Console.ResetColor();
                }

            // kullanıcı bi tık danaysa ve 1 - 2 - 0 gibi değerlerin dışında
            // bir karakter girerse programın hata vermemesi için bu kod çalışacak
            if (secim != 1 || secim != 2 || secim != 0)
                { Console.WriteLine("Hatalı bir tuşlama yaptınız");
                    goto tuslama1;
                }
              


            //                                              <3
           
        }
    }
}
