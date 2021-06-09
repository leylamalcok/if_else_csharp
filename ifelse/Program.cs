using System;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int yas;

            Console.WriteLine("Yaşınızı Giriniz:");
            Convert.ToInt32(Console.ReadLine());

            if (yas < 18)
                Console.WriteLine("Yaşınız 18 den küçük ehliyet alamazsınız.")

                    else
                Console.WriteLine("Ehliyet alabilirdiniz.");


        }
    }
}
