using System;

namespace CSHP03D_code_4._4
{
    class Program
    {
        static char Eingabe()
        {
            int einVariable;
            Console.Write("Geben Sie eine Zahl ein: ");
            einVariable = Convert.ToInt32(Console.ReadLine());
            return einVariable;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Die Methode Eingabe() liefert den Wert {0}.", Eingabe());
        }

    }
}
