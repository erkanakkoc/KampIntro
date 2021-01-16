using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kategoriler");

            Urun urun1 = new Urun();
            urun1.UrunId = 1;
            urun1.UrunAdi = "Telefon";
            urun1.UrunFiyat = 2399.99;

            Urun urun2 = new Urun();
            urun2.UrunId = 2;
            urun2.UrunAdi = "Laptop";
            urun2.UrunFiyat = 5999.99;

            Urun urun3 = new Urun();
            urun3.UrunId = 3;
            urun3.UrunAdi = "TV";
            urun3.UrunFiyat = 1499.99;

            //Console.WriteLine(urun1.UrunId + " " + urun1.UrunAdi + " " + urun1.UrunFiyat);
            //Console.WriteLine(urun2.UrunId + " " + urun2.UrunAdi + " " + urun2.UrunFiyat);
            //Console.WriteLine(urun3.UrunId + " " + urun3.UrunAdi + " " + urun3.UrunFiyat);

            Urun[] urunler = new Urun[] {urun1, urun2, urun3};


            Console.WriteLine("Foreach Döngüsü");
            
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunId + " " + urun.UrunAdi + " " + urun.UrunFiyat);
            }

            Console.WriteLine("For Döngüsü");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunId + " " + urunler[i].UrunAdi + " " + urunler[i].UrunFiyat);
            }

            Console.WriteLine("While Döngüsü");
            int j = 0;
            while (j < urunler.Length)
            {
                Console.WriteLine(urunler[j].UrunId + " " + urunler[j].UrunAdi + " " + urunler[j].UrunFiyat);
                j++;
            }



        }
    }

    class Urun
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public double UrunFiyat { get; set; }
    }


}
