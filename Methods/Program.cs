using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";


            Urun[] urunler = new Urun[] {urun1,urun2};

            //type safe- tip güvenli
            foreach (var urun in urunler)
            {
                Console.WriteLine("ürün adı "+ urun.Adi + " ürün fiyati: "+ urun.Fiyati+ " TL "+ "ürün acıklması: " + urun.Aciklama );
                Console.WriteLine("--------------------------");
            }

            Console.WriteLine("---------------Methods----------------");
            //instance -örnek, reuseabilitty-tekrar tekrar kullanabilme
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //boyle olursa burya stok eklemek istediğinde patlarsın ,
            sepetManager.Ekle2("armut","yeşil armut",12,9);
            sepetManager.Ekle2("elma", "yeşil elma", 12,10);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 12,11);



        }
    }
}
// Dont repat your self - DRY- Clean Code- Best Practice