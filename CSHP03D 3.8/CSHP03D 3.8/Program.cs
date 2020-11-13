﻿/* ######################
 break in einer Schleife
#########################*/

using System;

namespace CSHP03D_3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int summe, schleifenVariable, eingabe;

            summe = 0;
            schleifenVariable = 1;

            while(schleifenVariable <= 10)
            {

                Console.Write("Geben Sie die {0}. Zahl ein: ", schleifenVariable);
                eingabe = Convert.ToInt32(Console.ReadLine());

                if (eingabe == 0)
                    break;
                summe = eingabe + summe;
                schleifenVariable++;

            }
            Console.WriteLine("Das Einlesen ist beendet.");
            Console.WriteLine("Die Summe der Zahlen ist {0}.", summe);

        }
    }
}
