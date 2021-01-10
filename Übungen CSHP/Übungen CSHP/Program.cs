using System;

namespace Übungen_CSHP
{
    class TV
    {
        public int lautstärke;
        public int programm;
        public bool eingeschaltet = false;

       public void Anschalten()
        {
            eingeschaltet = true;
            programm = 1;
            lautstärke = 10;
        }

        public void ÄndereLautstärke()
        {

        }

        public void ÄndereProgramm()
        {

        }

        public void Ausschalten()
        {
            if (eingeschaltet == true)
                Console.WriteLine();
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            

        }
    }
}
