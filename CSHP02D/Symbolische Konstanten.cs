/* Symbolische Konstanten
 (das Programm lässt sich nicht übersetzen) */

using System;

namespace Cshp02d_03_06
{
    class Programm
    {
        static void Main(string [] args)
        {
            //die Vereinbarung der symbolischen Konstanten
            const int konstante = 10;
            //Vereinbarung der Variablen
            int zahl2 = 15;
            int ausgabe;

            //Ausgabe der Konstante
            //bitte in einer Zeile eingeben
            Console.WriteLine("Konstante hat den Wert {0}", konstante);
            //Rechnung mit der Konstanten
            ausgabe = zahl2 + konstante;
            // Ausgabe des Ergebnisses
            Console.WriteLine("ausgabe hat den Wert {0}", ausgabe);
            //DAS GEHT NICHT!
            konstante = 5;
        }
    }
}


