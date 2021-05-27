using System;

namespace CSHP09D_1._4
{
    class Program
    {
        static int Subtraktion(int wert1, int wert2)
        {
            return (wert1 - wert2);
        }
        static void Main(string[] args)
        {
            int zahl;
            zahl = Subtraktion(10, 20);
            Console.WriteLine("Zahl hat den Wert {0}.", zahl);
        }
    }
}
