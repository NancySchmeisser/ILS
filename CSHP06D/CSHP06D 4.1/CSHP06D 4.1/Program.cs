using System;

namespace CSHP06D_4._1
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

        public virtual void Ausgeben()
        {
            Console.WriteLine("Die Ausgabe erfolgt aus {0} Baer ", this.GetType());
            Console.WriteLine("Der eventuell alte oder auch nicht Bär ist {0} Jahre alt und wiegt {1} Kilo", alter, gewicht);

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

        public override void Ausgeben()
        {
            Console.WriteLine("ELTERNBAER!!!!!");
            Console.WriteLine("Die Ausgabe erfolgt aus {0} Elternbaer", this.GetType());
            Console.WriteLine("Der alte Bär ist {0} Jahre alt und wiegt {1} Kilo und hat {2} Kinder", alter, gewicht, anzahlKinder);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* Baer alterBär = new Baer(200,3);


             ElternBaer papaBaer = new ElternBaer(500,5,20);

             Console.WriteLine("Der alte Bär ist {0} Jahre alt und wiegt {1} Kilo", alterBär.GetAlter(), alterBär.GetGewicht());
             Console.WriteLine("Der Papa-Bär ist {0} Jahre alt und wiegt {1} Kilo und hat {2} Kinder", papaBaer.GetAlter(), papaBaer.GetGewicht(), papaBaer.GetAnzahlKinder());
             papaBaer.Schock();
             Console.WriteLine("Der Papa-Bär ist {0} Jahre alt und wiegt {1} Kilo und hat {2} Kinder", papaBaer.GetAlter(), papaBaer.GetGewicht(), papaBaer.GetAnzahlKinder());*/


            Baer[] Baerenliste = new Baer[2];
            Baerenliste[0] = new Baer(200, 3);
            Baerenliste[1] = new ElternBaer(500, 5, 20);
            foreach (Baer testBaer in Baerenliste)
                testBaer.Ausgeben();


        }
    }
}
