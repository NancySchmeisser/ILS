using System;

namespace Übungen_CSHP
{
    class Program
    {

        public static double Addieren(double zahl1, double zahl2)
        {
            double ergebnis = zahl1 + zahl2;
            return ergebnis;
        }

        public static double Subtrahieren(double zahl1, double zahl2)
        {
            double ergebnis = zahl1 - zahl2;
            return ergebnis;
        }

        public static double Multiplizieren(double zahl1, double zahl2)
        {
            double ergebnis = zahl1 * zahl2;
            return ergebnis;
        }

        public static double Dividieren(double zahl1, double zahl2)
        {
            double ergebnis = zahl1 % zahl2;
            return ergebnis;
        }


        static void Main(string[] args)
        {
            string eingabe; 
            double zahl1, zahl2;

            Console.WriteLine("Geben Sie die erste Zahl ein!");
                zahl1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben Sie die zweite Zahl ein!");
                zahl2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Welche Rechenoperation möchten Sie durchführen? Addieren, Subtrahieren, Multiplizieren, Dividieren");
            eingabe = Console.ReadLine();
            double ergebnis;


            switch (eingabe) 
            {
                case "+":
                    ergebnis = Addieren(zahl1, zahl2);
                    break;

                case "-":
                    ergebnis = Subtrahieren(zahl1, zahl2);
                    break;

                case "*":
                    ergebnis = Multiplizieren(zahl1, zahl2);
                    break;

                case "/":
                    ergebnis = Dividieren(zahl1, zahl2);
                    break;
                default:
                    Console.WriteLine("Idiot");
                    ergebnis = 0;
                    break;
            }
            Console.WriteLine("Das Ergebnis ist {0}", ergebnis);
        }
    }
}
