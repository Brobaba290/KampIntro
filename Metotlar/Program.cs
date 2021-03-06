﻿using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {


            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            Urun urun1 = new Urun();

            urun1.Adı = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();

            urun2.Adı = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            //type - safe -- tip güvenliği
            foreach (var urun in urunler)
            {

                Console.WriteLine(urun.Adı);

                Console.WriteLine(urun.Fiyati);

                Console.WriteLine(urun.Aciklama);

                Console.WriteLine("---------------------");

            }


            Console.WriteLine("---------------Metotlar-----------------");
            //instance   -   örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 50);
        }
    }
}



// Do not repeat yourself   -   DRY