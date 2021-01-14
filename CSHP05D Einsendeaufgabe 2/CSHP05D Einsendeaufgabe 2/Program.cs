﻿/* ######################################################
Einsendeaufgabe 5.2
###################################################### */


using System;

namespace CSHP05D_Einsendeaufgabe_2
{
    class Listenelement
    {
        string daten;
        Listenelement naechster;

        public void SetDaten(string datenNeu)
        {
            daten = datenNeu;
            naechster = null;
        }

        public Listenelement Anhängen(string datenNeu)
        {
            if (naechster == null)
            {
                naechster = new Listenelement();
                naechster.SetDaten(datenNeu);
                Console.WriteLine("Daten {0} wurden eingefügt.", datenNeu);
                return naechster;
            }

            return naechster.Anhängen(datenNeu);
        }

        public void Ausgeben()
        {
            Console.WriteLine(daten);

            if (naechster != null)
                naechster.Ausgeben();
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
                listenEnde = listenEnde.Anhängen("Element " + element);
            listenAnfang.Ausgeben();
        }
    }
}
    
