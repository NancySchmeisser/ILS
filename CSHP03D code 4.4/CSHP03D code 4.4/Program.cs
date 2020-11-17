using System;

namespace CSHP03D_code_4._4
{
    class Program
    {
        static int Eingabe()
        {
            int einVariable;
            Console.Write("Geben Sie eine Zahl ein: ");
            einVariable = Convert.ToInt32(Console.ReadLine());
            if (einVariable <= 20)
            return einVariable;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Die Methode Eingabe() liefert den Wert {0}.", Eingabe());
        }

    }
}
