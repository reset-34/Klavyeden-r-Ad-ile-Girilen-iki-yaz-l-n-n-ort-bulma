using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyeden_Öğr_Adı_ile_Girilen_iki_yazılının_ort_bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci adını giriniz");
            string ad = Console.ReadLine();

            Console.WriteLine("1. yazılı notunu girin");
            int yazili1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("2. yazılı notunu girin");
            int yazili2 = Int32.Parse(Console.ReadLine());

            double ortalama = (yazili1 + yazili2) / 2;

            Console.WriteLine("{0} adlı öğrencinin yazılı ortalaması {1}", ad, ortalama);
            Console.ReadLine();
        }
    }
}
