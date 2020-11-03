/* Die Datentypen string und char */

using System;

namespace Datentypen_4._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vereinbarung der Variablen
            char charVariable;
            string stringVariable;
            //Werte zuweisen und ausgeben
            charVariable = 'A';
            //Das klappt nicht
            //charVariable = "A";
            stringVariable = "Ich bin eine Zeichenkette";

            Console.WriteLine("Das Zeichen: {0}", charVariable);
            Console.WriteLine("Die Zeichen: {0}", stringVariable);

            stringVariable = "Zeichenketten lassen sich ändern!";
            Console.WriteLine("Die Zeichenkette: {0}", stringVariable);

            stringVariable = "Auch das " + "Verketten funktionert!";
            Console.WriteLine("Die Zeichenkette: {0}", stringVariable);

        }
    }
}
