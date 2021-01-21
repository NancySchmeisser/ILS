using System;

namespace CSHP06D_Einsendeaufgabe_1
{

    class Hund
    {
        int alter = 5;
        int gewicht = 20;

        public int GetAlter()
        {
            return alter;
        }

        public int GetGewicht()
        {
            return gewicht;
        }
    }

    class KleinerHund : Hund
    {
        int größe = 10;

        public int GetGroeße()
        {
            return größe;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            KleinerHund Struppi = new KleinerHund();

            Console.WriteLine("Struppi ist {0} Jahre alt, wiegt {1} Kilo und ist {2} Zentimeter groß", Struppi.GetAlter(), Struppi.GetGewicht(), Struppi.GetGroeße());
        }
    }
}
