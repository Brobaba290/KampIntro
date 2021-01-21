using System;

namespace E_Ticaret
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Tablet";
            urun1.Fiyati = 1800;
            urun1.Aciklama = "16 GB Hafıza";
            urun1.StokAdedi = "20 Adet Stokta";

            Urun urun2 = new Urun();
            urun2.Adi = "Telefon";
            urun2.Fiyati = 2000;
            urun2.Aciklama = "128 GB Hafıza";
            urun2.StokAdedi = "10 Adet Stokta";


            Urun[] urunler = new Urun[] { urun1, urun2 };

            Console.WriteLine("********** For Dongusu **********");
            Console.WriteLine(" ");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("Ürün Adı : " + urunler[i].Adi);
                Console.WriteLine("Ürün Fiyatı : " + urunler[i].Fiyati + " " + "TL");
                Console.WriteLine("Ürün Açıklaması : " + urunler[i].Aciklama);
                Console.WriteLine("Ürünün Stok Adedi : " + urunler[i].StokAdedi);
                Console.WriteLine("-----");
                Console.WriteLine(" ");

            }

            Console.WriteLine("********** Foreach Dongusu **********");
            Console.WriteLine(" ");
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün Adı : " + urun.Adi);
                Console.WriteLine("Ürün Fiyatı : " + urun.Fiyati + " " + "TL");
                Console.WriteLine("Ürün Açıklaması : " + urun.Aciklama);
                Console.WriteLine("Ürünün Stok Adedi :" + urun.StokAdedi);
                Console.WriteLine("-----");
                Console.WriteLine(" ");
            }
            Console.WriteLine("********** While Dongusu **********");
            Console.WriteLine(" ");
            int x = 0;
            while (x < 2)
            {
                Console.WriteLine("Ürün Adı : " + urunler[x].Adi);
                Console.WriteLine("Ürün Fiyatı : " + urunler[x].Fiyati + " " + "TL");
                Console.WriteLine("Ürün Açıklaması : " + urunler[x].Aciklama);
                Console.WriteLine("Ürünün Stok Adedi : " + urunler[x].StokAdedi);
                Console.WriteLine("-----");
                x++;
            }
        }
    }
}
