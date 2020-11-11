/* ################
 switch ... case
################# */

using System;

namespace CSHP03D_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            char essenWahl;

            Console.WriteLine("Sie haben folgende Auswahl: \n");
            Console.WriteLine("a Azad");
            Console.WriteLine("b Maykels");
            Console.WriteLine("c irgendein Chinese \n");
            Console.Write("Was möchten Sie essen? ");

            essenWahl = Convert.ToChar(Console.Read());

            //Die Auswertung von essenWahl
            switch (essenWahl)
            {
                //der case-Zweig für a
                case 'a':
                    Console.WriteLine("Sie haben Azad gewählt!");
                    Console.WriteLine("Davon wirst du garantiert fett!");
                    break;
                //der case-Zweig für b
                case 'b':
                    Console.WriteLine("Sie haben Maykels gewählt!");
                    Console.WriteLine("Da gibt es durchaus auch was Leichtes, dauert aber!");
                    break;
                //der case-Zweig für c
                case 'c':
                    Console.WriteLine("Sie haben Chinese gewählt!");
                    Console.WriteLine("Hattest du gestern erst, aber was solls!");
                    break;
                //für alles andere
                default:
                    Console.WriteLine("Sie haben keine gültige Auswahl getroffen!");
                    Console.WriteLine("Sie werden in der Hölle schmoren, wenn sie ihr Nancy nicht füttern!");
                    break;
            }

        }
    }
}
