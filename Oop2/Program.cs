﻿// See httusing System;

namespace Oop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hasanyanar
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "hasan";
            musteri1.Soyadi = "yanar";
            musteri1.TcNo = "11111111111";

            //kodlamaio
            TuzelMusteri musteri2 =new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "1234567890";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            customerManager customerManager = new customerManager();

            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

        }
    }
}