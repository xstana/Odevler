using System;
using System.Threading;
namespace EnKucuk
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
            double sayi1 = 0, sayi2 = 0, sayi3 = 0; // Sonradan kullanılacak değişkenlerin tanımlanması
            Console.Title = ("****  3 Sayıdan en küçüğü V2 - Orkun ONUK  ****"); // Consolun adını değiştirdik
            Console.ForegroundColor = ConsoleColor.Blue;
            daktilo("Bu program girilen 3 sayı arasından en küçüğünü verecektir.",55);
            daktilo("....", 1000);
            Console.Clear();
            Console.ResetColor();

            // Sayıların kullanıcıdan alınması / Readline ile okunup double olarak değişkenlere atanması
            daktilo("1. Sayıyı Giriniz\n>> ",35);
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            daktilo("2. Sayıyı Giriniz\n>> ", 35);
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            daktilo("3. Sayıyı Giriniz\n>> ", 35);
            sayi3 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            if (sayi1 < sayi2 && sayi1 < sayi3)  // Sayı 1'in sayı 2 ve 3 ten küçük olduğu if koşulu

            {
                // Sonucun yazdırılması
                daktilo("3 sayının arasından en küçük sayı : "+sayi1+ "\n" +
                            "\nBu sayıyı 1. adımda girdiniz", 90);
            }


            else if (sayi2 < sayi1 && sayi2 < sayi3) // Sayı 2'nin sayı 1 ve 3 ten küçük olduğu if koşulu

            {
                // Sonucun yazdırılması
                daktilo("3 sayının arasından en küçük sayı : " + sayi2 + "\n" +
                            "\nBu sayıyı 2. adımda girdiniz", 90);
            }

            else if (sayi3 < sayi1 && sayi3 < sayi2)// Sayı 3'ün sayı 1 ve 2 den küçük olduğu if koşulu

            {
                // Sonucun yazdırılması
                daktilo("3 sayının arasından en küçük sayı : " + sayi3 + "\n" +
                            "\nBu sayıyı 3. adımda girdiniz", 90);
            }


            Console.ResetColor();

            // Orkun Onuk 21908004

            Console.ReadKey();
        }
    }
}
