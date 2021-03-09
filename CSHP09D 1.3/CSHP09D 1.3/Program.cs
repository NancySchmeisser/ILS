using System;

namespace CSHP09D_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl;
            Console.WriteLine("Bitte geben Sie eine ganze Zahl ein: ");
            zahl = Convert.ToInt32(Console.ReadLine());

            if (zahl == 5)
                zahl = zahl + 10;
            if (zahl <= 5)
                zahl = zahl + 20;
            if (zahl > 5)
                zahl = zahl + 30;
            Console.WriteLine("Zahl hat den Wert {0}.", zahl);

        }
    }
}
