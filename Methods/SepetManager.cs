﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        // naming convention
        //syntax
        public void Ekle(Urun urun)
        {

            Console.WriteLine("Sepete eklendi:" + urun.Adi);

        }

        // böyle yazmamalıyız
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi:" + urunAdi);
        }
    }
}
