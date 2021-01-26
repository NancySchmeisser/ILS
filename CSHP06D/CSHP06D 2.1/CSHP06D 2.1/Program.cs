using System;

namespace CSHP06D_2._1
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
            Sherry flasche1 = new Sherry(10,1);

            flasche1.Ansehen();
        }
    }
}
