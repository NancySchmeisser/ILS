/* ########################
  Einfache if-Verzweigung
##########################*/

using System;

namespace CSHP03D_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl;

            Console.Write("Bitte geben Sie eine Zahl ein: ");
            zahl = Convert.ToInt32(Console.ReadLine());

            //die Verzweigung
            if (zahl > 5)
            {

                Console.WriteLine("Sie haben eine Zahl größer als 5 eingegeben");
                Console.WriteLine("Die Differenz zwischen {0} und 5 ist {1}.", zahl, zahl - 5);
            }
                Console.WriteLine("Die Zahl war {0}.", zahl);
            
        }
    }
}