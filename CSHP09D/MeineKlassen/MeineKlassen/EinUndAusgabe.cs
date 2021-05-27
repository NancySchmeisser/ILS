using System;

namespace MeineKlassen
{
    public class EinUndAusgabe
    {
        static public string Eingabe()
        {
            string zeichenkette;
            Console.WriteLine("Bitte geben Sie einen Wert ein: ");
            zeichenkette = Console.ReadLine();
            return zeichenkette;

        }

        static public void Ausgabe(string wert)
        {
            Console.WriteLine("Ihre Eingabe war: {0}", wert);
        }
    }
}
