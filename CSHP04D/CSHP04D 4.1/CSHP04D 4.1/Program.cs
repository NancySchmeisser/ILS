using System;

namespace CSHP04D_4._1
{
    class Program 
    { 
            struct Kiste
            {
                public int Hoehe;
                public int Breite;
                public int Laenge;
            }

            static Kiste Einlesen(int kistenNummer)
            {
                Kiste aKiste;
                Console.WriteLine("Geben Sie die Höhe der Kiste {0}. ein: ", kistenNummer);
                aKiste.Hoehe = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Geben Sie die Breite der Kiste {0}. ein: ", kistenNummer);
                aKiste.Breite = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Geben Sie die Länge der Kiste {0}. ein: ", kistenNummer);
                aKiste.Laenge = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                return aKiste;
            }

            static int Volumen(Kiste aKiste)
            {
                int volWert;
                volWert = aKiste.Breite * aKiste.Laenge * aKiste.Hoehe;
                return volWert;
            }
        
        
        static void Main(string[] args)
        {
            Kiste[] kleineKiste = new Kiste[3];

            for (int index = 0; index < 3; index++)
                kleineKiste[index] = Einlesen(index + 1);

            for (int index = 0; index < 3; index++)
                Console.WriteLine("Das Volumen von Kiste {0} ist: {1}", index + 1, Volumen(kleineKiste[index]));
        }
    }
}
