using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "kazak";
            urun1.fiyat = 100;
            urun1.marka = "beymen";

            Urun urun2 = new Urun();
            urun2.UrunAdi = "hırka";
            urun2.fiyat = 75;
            urun2.marka = "zara";

            Urun[] urunler = new Urun[] { urun1, urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün Adı: " + urun.UrunAdi);
                Console.WriteLine("Fiyatı: " + urun.fiyat);
                Console.WriteLine("Marka: " + urun.marka);



            }
        }

    }

    class Urun
    {
        public string UrunAdi { get; set; }
        public int fiyat { get; set; }
        public string marka { get; set; }

    }
}
