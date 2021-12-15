using System;

namespace EnKucuk
{
    class Program
    {
        static void Main(string[] args)
        {

            double sayi1 = 0, sayi2 = 0, sayi3 = 0; // Sonradan kullanılacak değişkenlerin tanımlanması

            Console.WriteLine("Ondalıklı sayı girerken virgül kullanınız. \n ");

            // Sayıların kullanıcıdan alınması / Readline ile okunup double olarak değişkenlere atanması
            Console.WriteLine("1. Sayıyı Giriniz : ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("2. Sayıyı Giriniz : ");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("3. Sayıyı Giriniz :  ");
            sayi3 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            if (sayi1 < sayi2 && sayi1 < sayi3)  // Sayı 1'in sayı 2 ve 3 ten küçük olduğu if koşulu

            {
                // Sonucun yazdırılması
                Console.WriteLine("\n 3 sayının arasından en küçük sayı : {0} \n" +
                            " Bu sayıyı 1. adımda girdiniz", sayi1);
            }


            else if (sayi2 < sayi1 && sayi2 < sayi3) // Sayı 2'nin sayı 1 ve 3 ten küçük olduğu if koşulu

            {
                // Sonucun yazdırılması
                Console.WriteLine("\n 3 sayının arasından en küçük sayı :{0} \n" +
                           " Bu sayıyı 2. adımda girdiniz", sayi2);
            }

            else if (sayi3 < sayi1 && sayi3 < sayi2)// Sayı 3'ün sayı 1 ve 2 den küçük olduğu if koşulu

            {
                // Sonucun yazdırılması
                Console.WriteLine("\n 3 sayının arasından en küçük sayı : {0} \n" +
                        " Bu sayıyı 3. adımda girdiniz", sayi3);
            }

            Console.ResetColor();

            // Orkun Onuk 21908004

            Console.ReadKey();
        }
    }
}
