using System;

namespace CSHP06D_5._1
{
    class Baer
    {
        protected int gewicht;
        protected int alter;
    
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

        public void Ausgeben()
        {
            Console.WriteLine("Die Ausgabe erfolgt aus {0}", this.GetType());
            Console.WriteLine("Der Bär ist {0} Jahre alt und wiegt {1} Kilo", alter, gewicht);
        }
    }

    class ElternBaer: Baer
    {
        int anzahlKinder;

        public ElternBaer(int gewicht, int alter, int anzahlKinder) : base (gewicht, alter)
        {
            this.anzahlKinder = anzahlKinder;
        }

        public int GetAnzahlKinder()
        {
            return anzahlKinder;
        }

        public void Ausgeben()
        {
            Console.WriteLine("Die Ausgabe erfolgt aus {0}", this.GetType());
            Console.WriteLine("Der Bär ist {0} Jahre alt, wiegt {1} Kilo und hat {2} Kinder", alter, gewicht, anzahlKinder);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Baer alterBaer = new Baer(200, 3);

            ElternBaer papaBaer = new ElternBaer(500, 5, 20);

            alterBaer.Ausgeben();
            papaBaer.Ausgeben();

        }
    }
}
