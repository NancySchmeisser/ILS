using System;

namespace CSHP06D_1._1
{

    class Esel
    {
        public int sturheit;
        public int gewicht;


        public void Arbeiten()
        {
            if (sturheit > 9 || gewicht < 10)
                Console.WriteLine("Der Esel kann nicht arbeiten");
            else
            {
                sturheit++;
                gewicht--;
                Console.WriteLine("Der Esel hat jetzt gearbeitet");
            }
        }

        public void Fressen()
        {
            gewicht++;
            if (sturheit > 0)
                sturheit--;
            Console.WriteLine("Der Esel hat jetzt gefressen");
        }

        public int Wiegen()
        {
            return gewicht;
        }

        public void Init()
        {
            gewicht = 15;
            sturheit = 5;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Esel eselchen = new Esel();

            eselchen.Init();
            eselchen.Arbeiten();
            eselchen.Fressen();
            Console.WriteLine("Der Esel wiegt {0} Kilo.", eselchen.Wiegen());
            
        }
    }
}
