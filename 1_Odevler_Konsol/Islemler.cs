using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Odevler_Konsol
{
    internal class Islemler
    {
        public void MerhabaDe(int sayi)
        {
            for (int i = 1; i <= sayi; i++)
            {
                Console.WriteLine("{0}. Merhaba Dünya",i);
            }
        }

        public void KaresiniBul(int sayi1,int sayi2)
        {
            int sonuc = sayi1 * sayi2;

            Console.WriteLine("Sayıların Çarpımı : "+sonuc);

            int sonucKaresi = sonuc * sonuc;

            Console.WriteLine("Çıkan Sonucun Karesi"+sonucKaresi);

            if (sonucKaresi == 1000)
            {
                Console.WriteLine("1000' e Eşit!");
            }
            else if (sonucKaresi < 1000)
            {
                Console.WriteLine("1000'den Küçük!");
            }
            else
            {
                Console.WriteLine("1000'den Büyük");
            }
                        
                        
        }

        public void DikdortgenHesapla(int sayi1,int sayi2)
        {
            

            int cevresi = (sayi1 + sayi2) * 2;

            int alani = sayi1 * sayi2;

            Console.WriteLine("Dikdörtgenin Çevresi : "+cevresi);
            Console.WriteLine("Dikdörtgenin Alanı : "+alani);
        }
        public void CemberHesapla(int daire)
        {
            double pi = 3.14;
            

            double daireAlan = pi * daire;

            Console.WriteLine("Dairenin Alanı : " + daireAlan);
        }
    }
}
