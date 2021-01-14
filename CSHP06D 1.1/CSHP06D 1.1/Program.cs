using System;

namespace CSHP06D_1._1
{

    class Esel
    {
        int sturheit;
        public int gewicht;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Esel eselchen = new Esel();

            eselchen.gewicht = 10;

            Console.WriteLine("Der Esel wiegt {0} Kilo", eselchen.gewicht);
            
        }
    }
}
