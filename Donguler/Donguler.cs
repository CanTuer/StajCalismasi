using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Donguler
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

            //Console.WriteLine(kurs1);
            //Console.WriteLine(kurs2);
            //Console.WriteLine(kurs3);

            //array-dizi
            string[] Kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs","Java " };
            for (int x = 0; x < Kurslar.Length; x++)
            {
                Console.WriteLine(Kurslar[x]);
            }
            Console.WriteLine("-------------------------------------------");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------------------------");
            //2'şer arttırma
            for (int j = 0; j <= 10; j += 2)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("-----------------------------------");
            foreach (string kurs in Kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.ReadLine();
        }
    }
}
