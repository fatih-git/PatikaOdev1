using System;

namespace Patika
{

    /*
    class Patika1
    {

        static void Main(string[] args)
        {
            int deger = 0;
            uint n = 0;
            Console.Write("Please enter a psitive integer: ");
            n = Convert.ToUInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Please enter a number: ");
                deger = Convert.ToInt32(Console.ReadLine());

                if (deger % 2 == 0)
                    Console.WriteLine(deger + " bir çift sayıdır.");
            }

        }

    }
    */

    /*
    class Patika2
    {

        static void Main(string[] args)
        {
            
            uint n = 0;
            uint m = 0;
            Console.Write("Pozitif bir değer giriniz: ");
            n = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Pozitif bir değer giriniz: ");
            m = Convert.ToUInt32(Console.ReadLine());

            int deger = 0;
            for(int i=0; i < n; i++)
            {
                Console.Write("Bir sayı giriniz: ");
                deger = Convert.ToInt32(Console.ReadLine());

                if (deger % m == 0)
                    Console.WriteLine(deger);

            }

        }

    }
    */

    /*
    class Patika3
    {

        static void Main(string[] args)
        {
            uint n = 0;
            Console.Write("Bir değer giriniz: ");
            n = Convert.ToUInt32(Console.ReadLine());

            string []dizi = new string[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Bir kelime giriniz: ");
                dizi[i] = Console.ReadLine();
            }

            for(int j=0; j<n; j++)
            {
                Console.Write(dizi[j] + " ");
            }

        }

    }
    */

    /*
    class Patika4
    {

        static void Main(string[] args)
        {
            string sentence;
            Console.Write("Lütfen bir cümle ya da kelime giriniz: ");
            sentence = Console.ReadLine();

            Console.WriteLine("Girilen cümlede bulunan karakter sayısı: "+sentence.Count());
        }

    }
    */

}