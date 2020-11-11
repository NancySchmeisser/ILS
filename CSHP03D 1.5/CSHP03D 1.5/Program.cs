/* ###########################################################
 Kombination von logischen Operatoren mit Vergleichsoperatoren
############################################################ */

using System;

namespace CSHP03D_1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int wertA, wertB, wertC;
            bool ergebnis;

            //Eingabeteil
            Console.Write("Geben Sie den Wert für A ein: ");
            wertA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geben Sie den Wert für B ein: ");
            wertB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geben Sie den Wert für C ein: ");
            wertC = Convert.ToInt32(Console.ReadLine());

            //Ausgabeteil

            ergebnis = (wertA < wertB) && (wertB < wertC);

            Console.WriteLine("A ist kleiner als B und B ist kleiner als C: {0}", ergebnis);

            ergebnis = (wertA < wertB) || (wertB < wertC);
            Console.WriteLine("A ist kleiner als B oder B ist kleiner als C: {0}", ergebnis);

            ergebnis = (wertA == wertB) || !(wertB < wertC);
            Console.WriteLine("A ist gleich B oder B ist nicht kleiner als C: {0}", ergebnis);
        }
    }
}
