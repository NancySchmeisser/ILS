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

            //die Verzweigung, mit else
            if (zahl > 5)
            

                Console.WriteLine("Sie haben eine Zahl größer als 5 eingegeben.");
               else
                    Console.WriteLine("Sie haben eine Zahl kleiner als 5 oder 5 eingegeben.");
                Console.WriteLine("Die Zahl war {0}.", zahl);     
        }
    }
}