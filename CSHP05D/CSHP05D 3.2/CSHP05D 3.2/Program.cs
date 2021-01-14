using System;

namespace CSHP05D_3._2
{
    class Quadrat
    {
        static int ergebnis;

        public static int Berechnen(int wert)
        {
            ergebnis = wert * wert;
            return ergebnis;
        }
    }

    class Program 
    
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Das Quadrat von 4 ist {0}", Quadrat.Berechnen(4));  
            
        }
    }
}
