using System;

namespace CSHP03D_code_4._4
{
    class Program
    {
        static (int, int) Eingabe()
        {
            int einVariable1, einVariable2;
           
            Console.Write("Geben Sie Zahl 1 ein: ");
            einVariable1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geben Sie Zahl 2 ein: ");
            einVariable2 = Convert.ToInt32(Console.ReadLine());
            
            return (einVariable1, einVariable2);
        }
        static void Main(string[] args)
        {
            (int wert1, int wert2) = Eingabe();
            Console.WriteLine("Die Methode Eingabe() liefert die Werte {0} und {1}.", wert1, wert2);
        }

    }
}
