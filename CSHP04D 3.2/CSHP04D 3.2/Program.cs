using System;

namespace CSHP04D_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string zKette;
            char zeichen;
            int index = 0;
            int zaehler = 0;

            Console.Write("Bitte geben Sie eine Zeichenkette ein: ");
            zKette = Console.ReadLine();

            Console.Write("Nach welchem Zeichen soll gewsucht werden? ");
            zeichen = Convert.ToChar(Console.Read());

            index = zKette.IndexOf(zeichen);

            while (index >= 0)
            {
                index++;
                zaehler++;
                index = zKette.IndexOf(zeichen, index);
             }

            Console.WriteLine("\nIn der Zeichenkette {0} komt {1} {2} Mal vor.", zKette, zeichen, zaehler);


        }
    }
}
