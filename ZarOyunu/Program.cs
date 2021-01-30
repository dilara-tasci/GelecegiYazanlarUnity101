using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            TavlaZari tavlaZari1 = new TavlaZari(8);
            TavlaZari2 tavlaZari2 = new TavlaZari2(8);
            Console.WriteLine("Zar 1: " + tavlaZari1.ZarAt());
            Console.WriteLine("Zar 2: " + tavlaZari2.ZarAt());
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine("Zar 1: " + tavlaZari1.ZarAt());
            Console.WriteLine("Zar 2: " + tavlaZari2.ZarAt());
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine("Zar 1: " + tavlaZari1.ZarAt());
            Console.WriteLine("Zar 2: " + tavlaZari2.ZarAt());
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine("Zar 1: " + tavlaZari1.ZarAt());
            Console.WriteLine("Zar 2: " + tavlaZari2.ZarAt());
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine("Zar 1: " + tavlaZari1.ZarAt());
            Console.WriteLine("Zar 2: " + tavlaZari2.ZarAt());
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine("Zar 1: " + tavlaZari1.ZarAt());
            Console.WriteLine("Zar 2: " + tavlaZari2.ZarAt());
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine("Zar 1: " + tavlaZari1.ZarAt());
            Console.WriteLine("Zar 2: " + tavlaZari2.ZarAt());
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine("Zar 1: " + tavlaZari1.ZarAt());
            Console.WriteLine("Zar 2: " + tavlaZari2.ZarAt());
            Console.WriteLine("//////////////////////////////");

            //tavlaZari2 adında yeni bir obje oluşturun 
            //Bu obje ile zar atıo konsola yazdırıp 1. ile yarıştırın
            Console.ReadKey();
        }
    }
}
