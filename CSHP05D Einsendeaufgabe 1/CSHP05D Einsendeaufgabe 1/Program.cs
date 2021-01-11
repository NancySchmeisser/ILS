using System;

namespace CSHP05D_Einsendeaufgabe_1
{
    class TV
    {
        private int lautstärke = 0;
        private int programm = 0;
        private string eingeschaltet = "aus";

        public void Anschalten()
        {
            if (eingeschaltet == "an")
                return;

            eingeschaltet = "an";
            programm = 1;
            lautstärke = 10;
            Console.WriteLine("Fernseher einschalten.");
        }

        public void ÄndereLautstärke(int neueLautstärke)
        {
            if (eingeschaltet != "an")
                return;

            lautstärke = neueLautstärke;
            Console.WriteLine("Lautstärke wurde auf {0} erhöht", neueLautstärke);
        }

        public void ÄndereProgramm(int neuesProgramm)
        {
            if (eingeschaltet != "an")
                return;

            programm = neuesProgramm;
            Console.WriteLine("Es wurde auf Programm {0} umgeschaltet", neuesProgramm);
        }

        public void Ausschalten()
        {
            if (eingeschaltet != "an")
                return;

            programm = 0;
            lautstärke = 0;
            Console.WriteLine("Fernseher wurde ausgeschaltet");
        }

        public void Ausgeben()
        {
            Console.WriteLine("Der Fernseher ist {0}. Es läuft Programm {1}. Lautstärke: {2}", eingeschaltet, programm, lautstärke);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TV Fernseher = new TV();

            Fernseher.Ausgeben();
            Fernseher.Anschalten();
            Fernseher.Ausgeben();
            Fernseher.ÄndereLautstärke(20);
            Fernseher.Ausgeben();
            Fernseher.ÄndereProgramm(2);
            Fernseher.Ausgeben();
            Fernseher.Ausschalten();
            Fernseher.Ausgeben();

        }
    }
}