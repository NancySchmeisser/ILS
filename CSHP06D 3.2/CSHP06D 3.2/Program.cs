using System;

namespace CSHP06D_3._2
{

    class Sherry
    {
        int alter;
        int liter;

        public Sherry(int alter, int liter)
        {
            this.alter = alter;
            this.liter = liter;
        }

        public Sherry(int alter)
        {
            this.alter = alter;
            this.liter = 1;
        }

        public Sherry()
        {
            this.alter = 10;
            this.liter = 1;
        }

        public void Ansehen()
        {
            Console.WriteLine("Der Sherry ist {0} Jahre alt", alter);
            Console.WriteLine("Die Flasche enthält {0} Liter", liter);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Sherry flasche1 = new Sherry(20, 2);
            Sherry flasche2 = new Sherry(15);
            Sherry flasche3 = new Sherry();

            flasche1.Ansehen();
            flasche2.Ansehen();
            flasche3.Ansehen();

        }
    }
}
