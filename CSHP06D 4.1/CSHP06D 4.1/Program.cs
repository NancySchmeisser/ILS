using System;

namespace CSHP06D_4._1
{
    class Baer
    {
        protected int gewicht;
        int alter;

        public Baer(int gewicht, int alter)
        {
            this.gewicht = gewicht;
            this.alter = alter;
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

        public ElternBaer(int gewicht, int alter, int anzahlKinder): base(gewicht, alter) 
        {
            this.anzahlKinder = anzahlKinder;
        }

        public int GetAnzahlKinder()
        {
            return anzahlKinder;
        }

        public void Schock()
        {
            gewicht--;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Baer alterBär = new Baer(200,3);

            ElternBaer papaBaer = new ElternBaer(500,5,20);

            Console.WriteLine("Der alte Bär ist {0} Jahre alt und wiegt {1} Kilo", alterBär.GetAlter(), alterBär.GetGewicht());
            Console.WriteLine("Der Papa-Bär ist {0} Jahre alt und wiegt {1} Kilo und hat {2} Kinder", papaBaer.GetAlter(), papaBaer.GetGewicht(), papaBaer.GetAnzahlKinder());
            papaBaer.Schock();
            Console.WriteLine("Der Papa-Bär ist {0} Jahre alt und wiegt {1} Kilo und hat {2} Kinder", papaBaer.GetAlter(), papaBaer.GetGewicht(), papaBaer.GetAnzahlKinder());

        }
    }
}
