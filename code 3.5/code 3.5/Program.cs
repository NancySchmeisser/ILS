using System;

namespace code_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl = 5;
            int ausgabe;

            //einfaches Inkrement
            Console.WriteLine("zahl hat den Wert {0}", zahl);
            ++zahl;
            //bitte in einer Zeile eingeben
            Console.WriteLine("zahl hat nach ++zahl den Wert {0}\n", zahl);

            //Inkrement nach der Zuweisung
            ausgabe = zahl++;
            //bitte jeweils in einer Zeile eingeben
            Console.WriteLine("ausgabe hat den Wert {0}", ausgabe);
            Console.WriteLine("zahl hat jetzt den Wert {0}\n", zahl);

            //Inkrement vor der Zuweisung
            ausgabe = ++zahl;
            //bitte jeweils in einer Zeile eingeben
            Console.WriteLine("ausgabe hat den Wert {0}", ausgabe);
            Console.WriteLine("zahl hat jetzt den Wert {0}\n", zahl);

            //entspricht zahl = zahl / 7
            zahl /= 7;
            //bitte in einer Zeile eingeben
            Console.WriteLine("zahl /= 7 liefert den Wert {0}\n", zahl);

            //entspricht zahl = zahl + 10
            zahl += 10;
            Console.WriteLine("zahl += 10 liefert den Wert {0}", zahl);




        }
    }
}
