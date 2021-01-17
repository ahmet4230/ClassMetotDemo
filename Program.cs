using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusterId = "0001";
            musteri1.MusteriAd = "Ahmet";
            musteri1.MusteriSoyad = "BATMAN";

            Musteri musteri2 = new Musteri();
            musteri2.MusterId = "0002";
            musteri2.MusteriAd = "Samet";
            musteri2.MusteriSoyad = "ATEŞ";

            Musteri musteri3 = new Musteri();
            musteri3.MusterId = ("00003");
            musteri3.MusteriAd = ("Erdoğan Kamil");
            musteri3.MusteriSoyad = ("GÜLEÇ");

            Musteri musteri4 = new Musteri();
            musteri4.MusterId = ("0004");
            musteri4.MusteriAd = ("Ali Ulvi");
            musteri4.MusteriSoyad = ("BATMAN");


            MusteriManager musteri = new MusteriManager();
            

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 , musteri4};

            musteri.MusteriEkle(musteri4);
            musteri.MusteriEkle(musteri3);
            musteri.MusteriSil(musteri2);
            musteri.MusteriListele(musteriler);
            musteri.MusteriEkle(musteri2);

            
           
            
           



           
        }
    }
}
