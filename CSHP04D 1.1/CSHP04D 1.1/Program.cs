using System;

namespace CSHP04D_1._1
{
    class Program
    {
        static void GibVarAus()
        {
            int varA = 4;
            Console.WriteLine("Der Wert der Variablen ist {0}", varA);
        }

        static void Main(string[] args)
        {
            GibVarAus();
            Console.WriteLine("Der Wert der Variablen ist {0}", varA);
        }
    }
}
