using System;

namespace CSHP06D_4._1
{
    class Baer
    {
        int gewicht;
        int alter;

        public Baer()
        {
            gewicht = 100;
            alter = 5;
        }

        public int GetGewicht()
        {
            return gewicht;
        }

        public int GetAlter()
        {
            return alter;
        }
    }

    class ElternBaer : Baer
    {
        int anzahlKinder;

        public ElternBaer()
        {
            anzahlKinder = 2;
        }

        public int GetAnzahlKinder()
        {
            return anzahlKinder;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Baer alterBär = new Baer();

            ElternBaer papaBaer = new ElternBaer();

            Console.WriteLine("Der alte Bär ist {0} Jahre alt und wiegt {1} Kilo", alterBär.GetAlter(), alterBär.GetGewicht());
            Console.WriteLine("Der Papa-Bär ist {0} Jahre alt und wiegt {1} Kilo und hat {2} Kinder", papaBaer.GetAlter(), papaBaer.GetGewicht(), papaBaer.GetAnzahlKinder());
        }
    }
}
