using System;

namespace Einsendeaufgabe_Wiederholung_CSHP04D
{
    class Program
    {
        struct Kiste
        {
            public int Nummer;
            public int Breite;
            public int Hoehe;
            public int Laenge;
            public int Volumen;
        }

        static void NeueKiste(Kiste [] lagerraum)
        {
            for (int i = 0; i < lagerraum.Length; i++)
            {

                if (lagerraum[i].Nummer == 0)
                {
                    lagerraum[i].Nummer = i + 1;
                    Console.WriteLine("Geben Sie die Breite der Kiste {0} ein:", i + 1);
                    lagerraum[i].Breite = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Geben Sie die Höhe der Kiste {0} ein:", i + 1);
                    lagerraum[i].Hoehe = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Geben Sie die Länge der Kiste {0} ein:", i + 1);
                    lagerraum[i].Laenge = Convert.ToInt32(Console.ReadLine());

                    lagerraum[i].Volumen = lagerraum[i].Breite * lagerraum[i].Hoehe * lagerraum[i].Laenge;
                    return;
                }
            }
        }

        static void Loeschen(Kiste[] lagerraum)
        {
            Console.WriteLine("Welche Kiste soll gelöscht werden?");
            int kistennummer = Convert.ToInt32(Console.ReadLine());

            if (kistennummer < 1 || kistennummer > 75)
            {
                Console.WriteLine("Idiot");
                return;
            }

            if(lagerraum[kistennummer -1].Nummer == 0)
            {
                Console.WriteLine("Idiot");
                return;
            }

            lagerraum[kistennummer-1].Nummer = 0;
        }



        static void Aendern(Kiste[] lagerraum)
        {
            Console.WriteLine("Welche Kiste soll geändert werden?");
            int kistennummer = Convert.ToInt32(Console.ReadLine());

            if (kistennummer < 1 || kistennummer > 75)
            {
                Console.WriteLine("Idiot");
                return;
            }

            if (lagerraum[kistennummer - 1].Nummer == 0)
            {
                Console.WriteLine("Idiot");
                return;
            }

            Console.WriteLine("Geben Sie die Breite der Kiste {0} ein:", kistennummer);
            lagerraum[kistennummer -1].Breite = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben Sie die Höhe der Kiste {0} ein:", kistennummer);
            lagerraum[kistennummer - 1].Hoehe = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben Sie die Länge der Kiste {0} ein:", kistennummer);
            lagerraum[kistennummer - 1].Laenge = Convert.ToInt32(Console.ReadLine());

            lagerraum[kistennummer - 1].Volumen = lagerraum[kistennummer - 1].Breite * lagerraum[kistennummer - 1].Hoehe * lagerraum[kistennummer - 1].Laenge;


        }


        static void Anzeigen(Kiste[] lagerraum)
        {
            Console.WriteLine("Welche Kiste soll angezeigt werden?");
            int kistennummer = Convert.ToInt32(Console.ReadLine());

            if (kistennummer < 1 || kistennummer > 75)
            {
                Console.WriteLine("Idiot");
                return;
            }

            if (lagerraum[kistennummer - 1].Nummer == 0)
            {
                Console.WriteLine("Idiot");
                return;
            }

            Console.WriteLine("Kistennummer: {0}, Breite: {1}, Höhe: {2}, Länge: {3}, Volumen: {4}", kistennummer, lagerraum[kistennummer - 1].Breite, lagerraum[kistennummer - 1].Hoehe, lagerraum[kistennummer - 1].Laenge, lagerraum[kistennummer - 1].Volumen);
        }

        static void Auflisten(Kiste[] lagerraum)
        {
            for (int i = 0; i < lagerraum.Length; i++)
            {
                if (lagerraum[i].Nummer != 0)
                {
                    Console.WriteLine("Kistennummer: {0}, Breite: {1}, Höhe: {2}, Länge: {3}, Volumen: {4}", i+1, lagerraum[i].Breite, lagerraum[i].Hoehe, lagerraum[i].Laenge, lagerraum[i].Volumen);

                }
            }
        }



        static void Main(string[] args)
        {
            Kiste[] lagerraum =  new Kiste[75];
            int auswahl;

            do
            {
                Console.WriteLine("Lagerverwaltung Version 3");
                Console.WriteLine("Wählen Sie");

                Console.WriteLine("1) Eingeben einer neuen Kiste");
                Console.WriteLine("2) Löschen einer Kiste");
                Console.WriteLine("3) Ändern einer Kiste");
                Console.WriteLine("4) Anzeigen einer Kiste");
                Console.WriteLine("5) Anzeigen aller Kisten");




                Console.WriteLine("6) Programm beenden");


                auswahl = Convert.ToInt32(Console.ReadLine());

                switch (auswahl)
                {
                    case 1:
                        NeueKiste(lagerraum);
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


                }
            } while (auswahl != 6);
        }

       
    }
}

