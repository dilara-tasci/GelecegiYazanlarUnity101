using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilkKonsolUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrana yazı yazdırmak (kötü)
            //konsola yazı yazdırmak (biraz daha iyi)
            //konsola Merhaba Dünya yazdırmak (çok daha iyi)
            //Console.WriteLine("Merhaba Dünya");
            
            //egzersiz 1
            //Console.WriteLine("C# ile programlama öğreniyorum");
            
            //integer türünde değişken tanımlamak
            int oyuncuPuani = 14;
            //Console.WriteLine(oyuncuPuani);

            //string türünde değişken tanımlamak
            string oyuncuAdi = "Player";
            //Console.WriteLine(oyuncuAdi);

            //egzersiz4
            /*
            string name = "Dilara";
            int age = 21;
            Console.WriteLine("adı: " + name);
            Console.WriteLine("yaşı: " + age);
            */

            //sabitler
            const int maksimumHiz = 200;
            //Console.WriteLine(maksimumHiz);

            //integer toplama işlemi
            int kazailanPuan = 10;
            oyuncuPuani += kazailanPuan;
            //Console.WriteLine(oyuncuPuani);

            //integer çıkartma işlemi
            int kaybedilenPuan = 15;
            oyuncuPuani -= kaybedilenPuan;
            //Console.WriteLine(oyuncuPuani);

            //integer çarpma işlemi
            oyuncuPuani *= 3;
            //Console.WriteLine(oyuncuPuani);

            //integer bölme işlemi
            oyuncuPuani /= 9;
            //Console.WriteLine(oyuncuPuani);

            //string toplama işlemi
            Console.WriteLine("Oyuncu Adı: " + oyuncuAdi + " Oyuncu Puanı: " + oyuncuPuani);

            //egzersiz 5
            /*
            int birthYear = 1999;
            int age = 2021 - birthYear;
            Console.WriteLine("Benim yaşım: " + age);
            */

            //Toplam oynama süresi (saniye)
            int toplamSaniye = 750;
            Console.WriteLine("Toplam saniye: " + toplamSaniye);

            //Toplam oynama süresi (dakika)
            float toplamDakika = toplamSaniye / 60f;
            Console.WriteLine("Toplam dakika: " + toplamDakika);

            //Hesaplanan saniye
            float hesaplananSaniye = toplamDakika * 60;
            Console.WriteLine("Hesaplanan saniye: " + hesaplananSaniye);

            //egzersiz 6
            /*
            int kenar1 = 21;
            int kenar2 = 23;
            float alan = (kenar1 * kenar2) / 2f;
            Console.WriteLine("Üçgenin Alanı: " + alan);
            */

            Console.ReadLine();
        }
    }
}
