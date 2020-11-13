/* #################
 while-Schleife
###################*/


using System;

namespace CSHP03D_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int schleifenVariable = 0;

            do
            {
                Console.Write("Bitte geben Sie einen Wert gröößer als 10 ein.");
                schleifenVariable = Convert.ToInt32(Console.ReadLine());
            }
            while (schleifenVariable >= 10);
            Console.WriteLine("Danke.");
            }
        }
    }

