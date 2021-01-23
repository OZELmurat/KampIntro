using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety= tip güvenliği
            //do not reapt ur self
            string kategoriEtiketi = "kategoriler";
            int ogrenciSayisi = 3200000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true; //javada boolean olarak yazılır



            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("kullanıcı ayarlar butonu");
            }
            else
            {
                Console.WriteLine("giris yap butonu");
            }



            Console.Write(kategoriEtiketi);
        }
    }
}
