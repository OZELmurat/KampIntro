﻿using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi 1 ?? cvp 30


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //Sayi1 ?? Cvp 999

            //bellekte stack ve heap diye alanlar vardır

            // değer olanlar int falan işte stack de gerçekleşir

            //arrayler ise heap de gerçekleşir yani referans tipler

        }
    }
}
