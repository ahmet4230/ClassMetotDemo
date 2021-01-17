using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi: " + musteri.MusteriAd + " " + musteri.MusteriSoyad + " Id no: " + musteri.MusterId);
        }
        
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi: " + musteri.MusteriAd + " " + musteri.MusteriSoyad + " Id no: " + musteri.MusterId);
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("MÜŞTERİ LİSTESİ " + musteri.MusteriAd + " " + musteri.MusteriSoyad + " Id no: " + musteri.MusterId);
            }
        }
    }
}