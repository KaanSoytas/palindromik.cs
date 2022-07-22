using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromik
{
    class Program
    {
        static void Main(string[] args)
        {
            palindromik();
        }   
        static void palindromik()
        {
            List<int> sayi = new List<int>();

            Console.WriteLine("kaç basamaklı sayı gireceksiniz?");
            int kacbasamak = Convert.ToInt32(Console.ReadLine());
            bool t = false;

            for (int i = 0; i < kacbasamak; i++)
            {
                
                Console.WriteLine((i + 1) + ". rakamı giriniz.");
                int a = Convert.ToInt32(Console.ReadLine());
                if(a<=9 && a >= 0)
                {
                    sayi.Add(a);
                }
                else
                {
                    Console.WriteLine("Rakam girmediniz");
                    palindromik();
                }

            }
            for (int i = 0; i <= sayi.Count / 2; i++)
            {
                if (sayi[i] == sayi[sayi.Count - 1])
                {
                    t = true;
                }
                else if (sayi[i] != sayi[kacbasamak - i - 1])
                {
                    t = false;
                }
            }
            if (t == true)
            {
                Console.WriteLine("sayı palindromiktir.");
            }
            else
            {
                Console.WriteLine("sayı palindromik değildir.");
            }
            Console.WriteLine("");
            Console.WriteLine("Devam etmek için d'ye basınız.");
            string d = Console.ReadLine();
            if(d == "d")
            {
                palindromik();
            }
            else
            {
                Console.WriteLine("Çıkış yapılıyor.");
            }

            Console.ReadLine();
        }
    }
}