using System;

namespace CSHP05D_3._3
{

    class Autoklasse
    {
        static int autoZaehler;
        int geschwindigkeit;


        public static int GetAutoZaehler()
        {
            return autoZaehler;
        }

        public void Initialisiere(int standard)
        {
            geschwindigkeit = standard;
            autoZaehler++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Autoklasse auto1 = new Autoklasse();
            Autoklasse auto2 = new Autoklasse();

            auto1.Initialisiere(0);
            auto2.Initialisiere(10);

            Console.WriteLine("Die Anzahl der Autos ist {0}", Autoklasse.GetAutoZaehler());

        }
    }
}
