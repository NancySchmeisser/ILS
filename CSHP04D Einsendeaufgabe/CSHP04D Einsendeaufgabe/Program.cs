﻿/* ######################################################
Einsendeaufgabe 4
###################################################### */


using System;
using System.Linq;

namespace CSHP04D_Einsendeaufgabe
{
    class Program
    {
        static Kiste[] lagerraum = new Kiste[2];
        struct Kiste
        {
            public int Hoehe;
            public int Breite;
            public int Laenge;
            public int Nummer;
            public int Volumen;
        }
        
        static Kiste NeueKiste(int kistenNummer)
        {
            Kiste aKiste;

            Console.Write("Geben Sie die Höhe der Kiste {0} ein: ", kistenNummer);
            aKiste.Hoehe = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geben Sie die Breite der Kiste {0} ein: ", kistenNummer);
            aKiste.Breite = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geben Sie die Länge der Kiste {0} ein: ", kistenNummer);
            aKiste.Laenge = Convert.ToInt32(Console.ReadLine());

            aKiste.Volumen = aKiste.Hoehe * aKiste.Breite * aKiste.Laenge;

            Console.WriteLine("Das Volumen dieser Kiste beträgt {0}", aKiste.Volumen);

            Console.WriteLine();
            aKiste.Nummer = kistenNummer;
            return aKiste;

        }

        static void Loeschen()
        {
            Console.WriteLine("Geben Sie die Nummer der Kiste ein, die sie löschen wollen (  ): ");
            int löschKiste = Convert.ToInt32(Console.ReadLine());
            lagerraum[löschKiste - 1].Nummer = 0;
        }

        static void Aendern(int kistenNummer)
        {
            Console.WriteLine("Geben Sie die Nummer der Kiste ein, die sie ändern wollen (1-75): ");

        }

        static void Anzeigen(int kistenNummer)
        {
            Console.WriteLine("Geben Sie die Nummer der Kiste ein, die sie anzeigen wollen (1-75): ");

        }

        static void Auflisten(int kistenNummer)
        {

        }



        static void Main(string[] args)
        {

            int auswahl = 0;

            do
            {
               
                Console.WriteLine("Willkommen in der Lagerverwaltung");
                Console.WriteLine("\nSie haben nun folgende Auswahl zur Verfügung: \n");
                Console.WriteLine("1)  neue Kiste eingeben");
                Console.WriteLine("2)  Datensatz löschen");
                Console.WriteLine("3)  Datensatz ändern");
                Console.WriteLine("4)  Datensatz anzeigen");
                Console.WriteLine("5)  Übersicht über alle angelegten Datensätze");
                Console.WriteLine("6)  Programm beenden\n\n");
                Console.Write("Bitte wählen Sie:\n");

                auswahl = Convert.ToInt32(Console.ReadLine());
                //Console.Clear();

                switch (auswahl)
                {
                    case 1:
                        Console.WriteLine("1");
                        for (int i = 0; i < lagerraum.Length; i++)
                        {
                            if (lagerraum[i].Nummer == 0) 
                            {
                                lagerraum[i] = NeueKiste(i + 1);
                                break;
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("2");
                        Loeschen();
                        break;
                    case 3:
                        Console.WriteLine("3");
                        Aendern(1);
                        break;
                    case 4:
                        Console.WriteLine("4");
                        Anzeigen(1);
                        break;
                    case 5:
                        Console.WriteLine("5");
                        Auflisten(1);
                        break;
                    case 6:
                        Console.WriteLine("6");

                        break;
                    default:
                        Console.WriteLine("Ihre Auswahl ist nicht gültig");
                        break;

                }
            }
            while (auswahl != 6); 
        }
    }
}
