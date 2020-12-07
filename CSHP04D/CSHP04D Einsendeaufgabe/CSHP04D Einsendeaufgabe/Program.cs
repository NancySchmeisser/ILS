/* ######################################################
Einsendeaufgabe 4
###################################################### */


using System;

namespace CSHP04D_Einsendeaufgabe
{
    class Program
    {
        struct Kiste
        {
            public int Hoehe;
            public int Breite;
            public int Laenge;
            public int Nummer;
            public int Volumen;
        }


        private static bool KisteAktiv(int kistennummer, Kiste[] lagerraum)
        {
            if (kistennummer < 1 || kistennummer > 75)
            {
                Console.WriteLine("Bitte geben sie eine Zahl zwischen 1 und 75 ein");
                return false;
            }

            if (lagerraum[kistennummer - 1].Nummer == 0)
            {
                Console.WriteLine("Diese Kiste existiert nicht");
                return false;
            }

            return true;
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

        static void Loeschen(Kiste[] lagerraum)
        {
            Console.WriteLine("Geben Sie die Nummer der Kiste ein, die sie löschen wollen (1-75): ");
            int löschKiste = Convert.ToInt32(Console.ReadLine());

            if (!KisteAktiv(löschKiste, lagerraum)) return;

            lagerraum[löschKiste - 1].Nummer = 0;
            Console.WriteLine("Die Kiste Nummer {0} wurde gelöscht \n", löschKiste);
        }

      

        static void Aendern(Kiste[] lagerraum)
        {
            Console.WriteLine("Geben Sie die Nummer der Kiste ein, die sie ändern wollen (1-75): ");
            int aenderKiste = Convert.ToInt32(Console.ReadLine());
            if (!KisteAktiv(aenderKiste, lagerraum)) return;

            lagerraum[aenderKiste - 1] = NeueKiste(aenderKiste);
        }


        static void Anzeigen(Kiste[] lagerraum)
        {
            Console.WriteLine("Geben Sie die Nummer der Kiste ein, die sie anzeigen wollen (1-75): ");
            int anzeigeKiste = Convert.ToInt32(Console.ReadLine());
            if (!KisteAktiv(anzeigeKiste, lagerraum)) return;
            var aKiste = lagerraum[anzeigeKiste - 1];
            Console.WriteLine("Kistennummer: {0}, Höhe: {1}, Breite: {2}, Länge: {3}, Volumen: {4}", aKiste.Nummer, aKiste.Hoehe, aKiste.Breite, aKiste.Laenge, aKiste.Volumen);
        }


        static void Auflisten(Kiste[] lagerraum)
        {
            for (int i = 0; i < lagerraum.Length; i++)
            {
                var aKiste = lagerraum[i];
                if (aKiste.Nummer != 0)
                    Console.WriteLine("Kistennummer: {0}, Höhe: {1}, Breite: {2}, Länge: {3}, Volumen: {4}", aKiste.Nummer, aKiste.Hoehe, aKiste.Breite, aKiste.Laenge, aKiste.Volumen);

            }
        }



        static void Main(string[] args)
        {

            int auswahl = 0;
            Kiste[] lagerraum = new Kiste[75];

            do
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("");
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


                switch (auswahl)
                {
                    case 1:
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
                        Loeschen(lagerraum);
                        break;
                    case 3:
                        Aendern(lagerraum);
                        break;
                    case 4:
                        Anzeigen(lagerraum);
                        break;
                    case 5:
                        Auflisten(lagerraum);
                        break;
                    case 6:
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
