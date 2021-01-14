using System;

namespace Übungen
{
    class Listenelement
    {
        string daten;
        Listenelement next;

        public void SetDaten(string datenNeu)
        {
            daten = datenNeu;
            next = null;
        }

        public Listenelement Anhängen(string datenNeu)
        {
            if (next == null)
            {
                next = new Listenelement();
                next.SetDaten(datenNeu);
                Console.WriteLine("Daten {0} wurden eingefügt", datenNeu);
                return next;
            }

            return next.Anhängen(datenNeu);
        }

        public void Ausgeben()
        {
            Console.WriteLine(daten);

            if (next != null)
                next.Ausgeben();
        }

        public void AusgebenRückwärts()
        {
            if (next != null)
                next.AusgebenRückwärts();

            Console.WriteLine(daten);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Listenelement listenAnfang = new Listenelement();
            Listenelement listenEnde = listenAnfang;

            listenAnfang.SetDaten("Element 1");

            for (int element = 2; element < 4; element++)
            {
                listenEnde = listenEnde.Anhängen("Element " + element);
                listenAnfang.Ausgeben();
            }
        }
    }
}
