using System;

namespace CSHP05D_5._1
{

    class Listenelement
    {
        public string Daten;
        public Listenelement Naechster;
    }
    class Program
    {
        static void SetDaten(string datenNeu, Listenelement element)
        {
            element.Daten = datenNeu;
            element.Naechster = null;
        }

        static Listenelement ListeAnhaengen(string datenNeu, Listenelement listenAnfang)
        {
            Listenelement current;

            // Suche letztes Element (das bei dem .Naechster == null ist)
            current = listenAnfang;
            while (current.Naechster != null)
                current = current.Naechster;

            // Jetzt ist current das letzte Element.
            Listenelement letzter = current;

            // Erzeuge neues Element und haenge es an das letzte an.
            Listenelement neuesElement = new Listenelement();
            SetDaten(datenNeu, neuesElement);
            letzter.Naechster = neuesElement;

            return neuesElement;
        }

        static void ListeAusgeben(Listenelement listenAnfang)
        {
            Listenelement current;
            current = listenAnfang;
            Console.WriteLine(current.Daten);
            while (current.Naechster != null)
            {
                current = current.Naechster;
                Console.WriteLine(current.Daten);
            }


        }
        static void Main(string[] args)
        {
            Listenelement listenAnfang = new Listenelement();
            Listenelement listenEnde = listenAnfang;

            SetDaten("Element 1", listenAnfang);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        

            for (int element = 2; element < 4; element++)
                listenEnde = ListeAnhaengen("Element " + element, listenEnde);

            ListeAusgeben(listenAnfang);
        }
    }
}
