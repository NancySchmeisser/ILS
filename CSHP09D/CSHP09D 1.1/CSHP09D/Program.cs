using System;

namespace CSHP09D
{
    class Program
    {
        static void Main(string[] args)
        {
            int zaehler = 1;
            while (zaehler < 11)
            {
                Console.WriteLine("Schleifendurchlauf {0}", zaehler);
                zaehler++;
            }
        }
    }
}
