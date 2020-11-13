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
                Console.WriteLine("Die Variable hat jetzt den Wert {0}", schleifenVariable);
                schleifenVariable++;
            }
            while (schleifenVariable <= 10);
         }
     }
 }

