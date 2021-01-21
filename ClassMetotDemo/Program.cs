using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
           
            musteri1.MusteriAdi = "Kaan";
            musteri1.MusteriSoyadi = "Demirtaş";
            musteri1.MusteriTelefon = 0123456789;
            musteri1.MusteriMail = "kaan@gmail.com";
            musteri1.MusteriSifre = 1590;
         

            Musteri musteri2 = new Musteri();

            musteri2.MusteriAdi = "Haydar";
            musteri2.MusteriSoyadi = "Erkan";
            musteri2.MusteriTelefon = 0123456789;
            musteri2.MusteriMail = "haydar@gmail.com";
            musteri2.MusteriSifre = 1235;

         
            Musteri musteri3 = new Musteri();

            musteri3.MusteriAdi = "Çağdaş";
            musteri3.MusteriSoyadi = "Kalın";
            musteri3.MusteriTelefon = 0123456789;
            musteri3.MusteriMail = "cagdas@gmail.com";
            musteri3.MusteriSifre = 2547;
         
    
            Musteri musteri4 = new Musteri();

            musteri4.MusteriAdi = "Gülüstan";
            musteri4.MusteriSoyadi = "Şahin";
            musteri4.MusteriTelefon = 0123456789;
            musteri4.MusteriMail = "gulustan@gmail.com";
            musteri4.MusteriSifre = 5475;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };


            foreach (Musteri musteri in musteriler)
            {

                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine(musteri.MusteriSoyadi);
                Console.WriteLine(musteri.MusteriTelefon);
                Console.WriteLine(musteri.MusteriMail);
                Console.WriteLine(musteri.MusteriSifre);
                

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("/--//--//--//--//--//--//--//--//--/");
                Console.ResetColor();
               
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------------");
            Console.ResetColor();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriEkle(musteri4);
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriSil(musteri3);
            musteriManager.MusteriSil(musteri4);
            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriListele(musteri2);
            musteriManager.MusteriListele(musteri3);
            musteriManager.MusteriListele(musteri4);

            Console.WriteLine("Hello World!");
        }
    }
}
