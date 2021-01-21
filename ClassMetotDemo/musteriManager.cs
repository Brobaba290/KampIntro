using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşterinin Adı ve Soyadı Onaylandı : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
            Console.WriteLine( "Müşterinin Telefonu Onaylandı : " + musteri.MusteriTelefon);
            Console.WriteLine("Müşterini Maili Onaylandı : " + musteri.MusteriMail);
            Console.WriteLine("Müsterinin Şifresi Onaylandı : " + musteri.MusteriSifre);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("/--//--//--//--//--//--//--//--//--/");
            Console.ResetColor();
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşterinin Adı Soyadı Silindi : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
            Console.WriteLine( "Müşterinin Telefonu Silindi : " + musteri.MusteriTelefon);
            Console.WriteLine("Müşteri Maili Silindi : " + musteri.MusteriMail);
            Console.WriteLine( "Müşteri Şifresi Silindi : " + musteri.MusteriSifre);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("/--//--//--//--//--//--//--//--//--/");
            Console.ResetColor();
        }


        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşterinin Adı Soyadı Listelendi : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
            Console.WriteLine("Müşterinin Telefonu Listelendi : " + musteri.MusteriTelefon);
            Console.WriteLine("Müşteri Maili Listelendi : " + musteri.MusteriMail);
            Console.WriteLine("Müşteri Şifresi Listelendi : " + musteri.MusteriSifre);
           
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("/--//--//--//--//--//--//--//--//--/");
            Console.ResetColor();
        }
    }
}
