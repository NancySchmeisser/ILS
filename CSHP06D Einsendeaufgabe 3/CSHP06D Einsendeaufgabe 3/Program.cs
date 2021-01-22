using System;

namespace CSHP06D_Einsendeaufgabe_3
{
    class Hund
    {
        int gewicht;
        int alter;

        public Hund(int gewicht, int alter)
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

        public void  SetAlter( int newAlter )
        {
            if (newAlter > 100) throw new ArgumentException("Hunde werden nicht so alt");
            alter = newAlter;
        }
    }

    class KleinerHund : Hund
    {
        private int groeße = 30;


        public KleinerHund(int alter, int gewicht, int groeße) : base(alter, gewicht)
        {
            this.gewicht = gewicht;
            SetAlter(alter);
            this.alter = alter;
            this.groeße = groeße;
        }

        public int GetGroeße()
        {
            return groeße;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            KleinerHund Struppi = new KleinerHund(5, 20, 30);

            Console.WriteLine("Struppi wiegt {0} Kilo und ist {1} Jahre alt und {2} Zentimeter groß", Struppi.GetGewicht(), Struppi.GetAlter(), Struppi.GetGroeße());
        }
    }
}
