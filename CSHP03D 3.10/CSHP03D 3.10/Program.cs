/* ########################
 continue in einer Schleife
##########################*/

using System;

namespace CSHP03D_3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int quadrat, schleifenVariable, eingabe;

            quadrat = 0;
            schleifenVariable = 1;

            while (schleifenVariable <= 10) 
            { 
                Console.WriteLine("Geben sie die Zahl {0} ein", schleifenVariable);
            eingabe = Convert.ToInt32(Console.ReadLine());

            
                if (eingabe != 0)
                {
                    quadrat = eingabe * eingabe;
                    Console.WriteLine("Das Quadrat der Zahl ist {0}", quadrat);
                }
                schleifenVariable++;
            }

        
         Console.WriteLine("Das Einlesen ist beendet.");   
        }
    }
}
