using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Odevler_Konsol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Islemler islemler = new Islemler(); // Class çağırdık. 

            // Bir Sayı girilmesini ve Bu Girilen Sayı kadar Merhaba yazdırdık.

            //Console.WriteLine("Lütfen Bir Sayı Giriniz : ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //islemler.MerhabaDe(sayi);

            // İki sayı girip çarpılıp çarpımın sonucunun karesi yazdırılcak.

            //Console.WriteLine("Birinci Sayıyı Gir : ");
            //int carpim1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci Sayıyı Gir : ");
            //int carpim2 = Convert.ToInt32(Console.ReadLine());
            //islemler.KaresiniBul(carpim1,carpim2);

            // Dikdörtgen alan ve çevre hesaplaması burada yapıldı...!! 

            //Console.WriteLine("Kısa Kenarı Giriniz : ");
            //int kisaKenar = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Uzun Kenarı Giriniz : ");
            //int uzunKenar = Convert.ToInt32(Console.ReadLine());
            //islemler.DikdortgenHesapla(kisaKenar,uzunKenar);

            // Daire Alan Hesaplaması Burada Yapıldı...!!!
            
            Console.WriteLine("Dairenin Yarı Çapı Uzunluğunu Giriniz : ");
            int daire = Convert.ToInt32(Console.ReadLine());
            islemler.CemberHesapla(daire);


            Console.ReadLine();
        }
    }
}
