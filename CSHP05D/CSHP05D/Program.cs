using System;

namespace CSHP05D
{
    class Autoklasse
    {
        int geschwindigkeit;



        public void Initialisieren(int standard)
        {
            geschwindigkeit = standard;
        }

        public void Bremsen(int aenderung)
        {
            if (geschwindigkeit - aenderung < 0)
                geschwindigkeit = 0;
            else
                geschwindigkeit = geschwindigkeit - aenderung;
        }

        public void Gasgeben(int aenderung)
        {
            geschwindigkeit = geschwindigkeit + aenderung;
        }

        public void Ausgeben()
        {
            Console.WriteLine("Die aktuelle Geschwindigkeit beträgt {0}.", geschwindigkeit);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Autoklasse auto1 = new Autoklasse();
            Autoklasse auto2 = new Autoklasse();

            auto1.Initialisieren(0);
            auto2.Initialisieren(10);

            Console.WriteLine("Nach der Initialisierung");
            auto1.Ausgeben();
            auto2.Ausgeben();

            auto1.Gasgeben(20);
            auto2.Gasgeben(100);

            Console.WriteLine("Nach Gasgeben");
            auto1.Ausgeben();
            auto2.Ausgeben();

            auto1.Bremsen(10);
            auto2.Bremsen(50);

            Console.WriteLine("Nach Bremsem");
            auto1.Ausgeben();
            auto2.Ausgeben();



        }
    }
}
