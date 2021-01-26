using System;

namespace CSHP06D_Einsendeaufgabe_5
{
    class Haustiere
    {
        int gewicht;
        int alter;
        public Haustiere(int gewicht, int alter)
        {
            this.gewicht = gewicht;
            this.alter = alter;
        }
    }

    class Vogel : Haustiere
    {
        int flügelLänge;
        public Vogel(int gewicht, int alter, int flügelLänge) : base (gewicht, alter)
        {
            this.flügelLänge = flügelLänge;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
