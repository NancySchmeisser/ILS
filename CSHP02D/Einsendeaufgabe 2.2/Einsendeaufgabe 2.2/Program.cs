/* #################################################
Einsendeaufgabe 2.2
################################################# */
    

using System;

namespace Einsendeaufgabe_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int eingabe1, eingabe2;

            Console.WriteLine("Bitte geben Sie den ersten Wert ein und drücken Sie dann die Eingabetaste.");
            eingabe1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie den zweiten Wert ein und drücken Sie dann die Eingabetaste");
            eingabe2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Die Division der Werte {0} und {1} ergibt = {2}", eingabe1, eingabe2, (double) eingabe1 / eingabe2);
        }
    }
}
