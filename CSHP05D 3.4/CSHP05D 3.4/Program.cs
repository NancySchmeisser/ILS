using System;

namespace CSHP05D_3._4
{
    
    class Ueberdeckt
    {
        string zeichenkette;


        public void ZeichenketteAendern(string zeichenkette)
        {
            this.zeichenkette = zeichenkette + " geändert";
        }

        public string GetZeichenkette()
        {
            return zeichenkette;
        }
    }
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Ueberdeckt test = new Ueberdeckt();
            test.ZeichenketteAendern("Test");

            Console.WriteLine("Der geänderte Wert ist {0}", test.GetZeichenkette());

            if (test.GetZeichenkette() == string.Empty)
                Console.WriteLine("Die Zeichenkette ist leer");
            else Console.WriteLine("Die Zeichenkette ist nicht leer");
        }
    }
}
