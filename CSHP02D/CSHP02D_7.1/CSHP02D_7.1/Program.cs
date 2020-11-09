/* Gestaltung von Konsolenprogrammen */

using System;

namespace CSHP02D_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vereinbarung der Variablen
            string eingabe1, eingabe2;

            //den Titel setzten
            Console.Title = "Nun sieht es netter aus!";

            //die Farben verändern
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;

        }
    }
}
