using System;

namespace CSHP03D_4._8
{
    class Program
    {
       static int Quadrat (int zahl)
        {
            int ergebnis;
            ergebnis = zahl * zahl;
            return ergebnis;
        }
        static void Main (String[] args)
        {
            int einVariable;

            Console.Write("Geben Sie eine Zahl ein: ");
            einVariable = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Das Quadrat der Zahl {0} ist {1}.", einVariable, Quadrat(einVariable));
        }
    }
}
