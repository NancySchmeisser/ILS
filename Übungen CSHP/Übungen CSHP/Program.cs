using System;

namespace Übungen_CSHP
{
    class TV
    {
        private int lautstärke = 0;
        private int programm = 0;
        private bool eingeschaltet = false;

       public void Anschalten()
        { if(eingeschaltet == false)
            eingeschaltet = true;
            programm = 1;
            lautstärke = 10;
            Console.WriteLine("Fernseher ist eingeschaltet.");
        }

        public void ÄndereLautstärke()
        {
            if (eingeschaltet == true)
                Console.WriteLine("Lautstärke wurde auf 20 erhöht");
        }

        public void ÄndereProgramm()
        {
            if (eingeschaltet == true)
                programm = 2;
            Console.WriteLine("Es wurde auf Kanal 2 umgeschaltet");
        }

        public void Ausschalten()
        {
            if (eingeschaltet == true)
                Console.WriteLine("Test Ausschalten");
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            TV Fernseher = new TV();

            Console.WriteLine("Fernseher ist ausgeschaltet");
            Fernseher.Anschalten();
            Console.WriteLine("Umschalten");
            Fernseher.ÄndereProgramm();
            Console.WriteLine("Lautstärke ändern");
            Fernseher.ÄndereLautstärke();



        }
    }
}
