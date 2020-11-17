using System;

namespace CSHP03D_code_4._4
{
    class Program
    {
        static int Eingabe()
        {
            int einVariable; einVariable2;
            Console.Write("Geben Sie die Zahl 1 ein: ");
            einVariable = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geben Sie die Zahl 2 ein: ");
            einVariable = Convert.ToInt32(Console.ReadLine());
            return (einVariable, einVariable2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Die Methode Eingabe() liefert den Wert {0}.", Eingabe());
        }

    }
}
