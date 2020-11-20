/* #################################################### 
Einsendeaufgabe 3.5 
#################################################### */


using System;

namespace Einsendeaufgabe_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            float zahl1, zahl2, ergebnis;

            Console.WriteLine("Bitte geben Sie 2 Zahlen ein und bestätigen sie mit ENTER");

            Console.Write("Erste Zahl: ");
            zahl1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Zweite Zahl: ");
            zahl2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Möchten Sie die beiden Zahlen addieren, subtrahieren, multiplizieren, dividieren oder potenzieren?");
            string operat = Console.ReadLine();


            switch (operat)

            { 
                case "+":

                    ergebnis = Addition(zahl1, zahl2);
                    break;

                case "-":

                    ergebnis = Subtraktion(zahl1, zahl2);
                    break;

                case "*":

                    ergebnis = Multiplikation(zahl1, zahl2);
                    break;

                case "/":

                    ergebnis = Division(zahl1, zahl2);
                    break;

                case "^":

                    ergebnis = Potenz(zahl1, zahl2);
                    break;

                default:

                    Console.WriteLine("Wert ungültig! Sie dürfen nur *,+,-,/ eingeben");
                    Console.ReadLine();
                    return;

            }
            Console.WriteLine("{0} {1} {2} = {3} ", zahl1, operat, zahl2, ergebnis);
            Console.ReadLine();
        }

        static float Multiplikation(float zahl1, float zahl2)
        {
            return (zahl1 * zahl2);
        }

        static float Addition(float zahl1, float zahl2)
        {
            return (zahl1 + zahl2);
        }

        static float Subtraktion(float zahl1, float zahl2)
        {
            return (zahl1 - zahl2);
        }

        static float Division(float zahl1, float zahl2)
        {
            return (zahl1 / zahl2);
        }


        static float Potenz(float basis, float exponent)
        {
            float ergebnis = 1;
 
            for (int i = 0; i<exponent; i++)
            {
                ergebnis = ergebnis * basis;
            }
            return ergebnis;

        }
    }
}
