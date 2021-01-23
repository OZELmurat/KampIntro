using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.kursadi = "c#";
            kurs1.egitmen = "engin demirog";
            kurs1.izlenmeOrani = 68;

            kurs kurs2 = new kurs();
            kurs2.kursadi = "java";
            kurs2.egitmen = "murat";
            kurs2.izlenmeOrani = 50;

            kurs[] kurslar = new kurs[]{
            
                kurs1,kurs2
            
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursadi +" : " + kurs.egitmen);
            }


          //  Console.WriteLine(kurs1.kursadi+ ": " + kurs1.egitmen+ " ilerleme durumu " + kurs1.izlenmeOrani);
        }
    }

    class kurs
    {
        public string kursadi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }

}
