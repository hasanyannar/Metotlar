using Metotlar;
using System;


namespace Methotlar 
{

	class Program
	{
		static void Main(string[] args)
		{

			string urunAdi = "Elma";
			double fiyati = 15;
			string aciklama = "amasya elması";

			Urun Urun1 = new Urun();

			Urun1.Adi = "Misket";
			Urun1.Fiyati = 15;
			Urun1.Aciklama = "amasya elması";

			Urun Urun2 = new Urun();

			Urun2.Adi = "Elma";
			Urun2.Fiyati= 18;
			Urun2.Aciklama = "niğde elması";

			Urun[] urunler = new Urun[] {Urun1,Urun2};	

			foreach (var urun in urunler)
			{
				Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
            }

			Console.WriteLine("-----------metotlar--------------");


			SepetManager sepetmanager = new SepetManager();
			sepetmanager.Ekle(Urun1);
			sepetmanager.Ekle(Urun2);
        }
	}
}