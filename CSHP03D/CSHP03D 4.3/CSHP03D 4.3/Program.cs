using System;

namespace CSHP03D_4._3
{
    class Program
    {
        static int Rueckgabe100()
        {
            return 100;
        }

        static int Rueckgabe10()
        {
            return 10;
        }

        static void Main(string[] args)
        {
            int ergebnis;

            Console.WriteLine("Die Methode Rueckgabe100() liefert den Wert {0}.", Rueckgabe100());
            Console.WriteLine("Die Methode Rueckgabe10() liefert den Wert {0}.", Rueckgabe10());

            ergebnis = Rueckgabe100() + Rueckgabe10();
            Console.WriteLine("Das Ergebnis ist {0}.", ergebnis);

            Console.Write("Geben Sie eine Zahl ein: ");
            ergebnis = Convert.ToInt32(Console.ReadLine());
            if (ergebnis < Rueckgabe100())
                Console.WriteLine("Ihr Eingabe war kleiner als 100");

        }

    }
}
