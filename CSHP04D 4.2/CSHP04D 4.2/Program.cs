using System;

namespace CSHP04D_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var testTupel = ("Text", 1, 2.09);
            Console.WriteLine("Das erste Element hat den Wert {0}", testTupel.Item1);

            var kiste = (name: "Kiste 1", breite: 1.00, hoehe: 2.09, laenge: 2.50);
            Console.WriteLine("Der Name ist {0}", kiste.name);

            var volumen = kiste.breite * kiste.laenge * kiste.hoehe;
            Console.WriteLine("Das Volumen beträgt: {0}.", volumen);

            var (name, breite, hoehe, laenge) = kiste;
            Console.WriteLine("Der Name ist {0}. Das Volumen beträgt {1}", name, breite * hoehe * laenge);
        }
    }
}
