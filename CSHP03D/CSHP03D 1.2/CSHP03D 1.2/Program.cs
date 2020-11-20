/* ##################################
 Logisches NICHT
##################################### */

using System;

namespace CSHP03D_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1, zahl2;
            zahl1 = 1;
            zahl2 = 2;

            //ein direkter Vergleich von zwei Zahlen
            Console.WriteLine("!(5 < 10) \t {0}", !(5 <10));

            //bitte jeweils in einer Zeile eingeben
            //ein Vergleich einer Zahl mit einer Variablen
            Console.WriteLine("!(5 > {0}) \t{1}", zahl1, !(5 > zahl1));

            //Vergleiche von 2 Variablen
            Console.WriteLine("!({0} == {1}) \t{2}", zahl1, zahl2, !(zahl1 ==zahl2));

            Console.WriteLine("!({0} != {1}) \t{2}", zahl1, zahl2, !(zahl1 != zahl2));
        }
    }
}
