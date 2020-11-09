using System;
using System.Linq.Expressions;

namespace CSHP03D
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1, zahl2;

            zahl1 = 1;
            zahl2 = 0;

            //ein direkter Vergleich von 2 Zahlen
            Console.WriteLine("5 < 10 \t{0}", 5 < 10);

            //Ein Vergleich einer Zahl mit einer Variablen
            Console.WriteLine("5 > {0} \t{1}", zahl1, 5 > zahl1);

            //vergleich von 2 Variablen
            Console.WriteLine("{0} == {1} \t{2}", zahl1, zahl2,
            zahl1 == zahl2);

            Console.WriteLine("{0} !d= {1} \t{2}", zahl1, zahl2,
            zahl1 != zahl2);
        }
    }
}
