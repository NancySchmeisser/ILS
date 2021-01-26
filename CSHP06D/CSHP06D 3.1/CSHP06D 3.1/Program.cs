using System;

namespace CSHP06D_3._1
{
    class Produkt
    {
        public static int Rechnung(int wert1, int wert2)
        {
            Console.WriteLine("Rechnung mit 2 Parametern");
            return (wert1 * wert2);
        }

        public static int Rechnung(int wert1, int wert2, int wert3)
        {
            Console.WriteLine("Rechnung mit 3 Parametern");
            return (wert1 * wert2 * wert3);
        }

        public static float Rechnung(float wert1, float wert2)
        {
            Console.WriteLine("Rechnung mit 2 float-Parametern");
            return (wert1 * wert2);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            float wert1 = 10.02F;
            float wert2 = 10.09F;

            Console.WriteLine("Der Aufruf mit zwei int-Argumenten: {0}", Produkt.Rechnung(10, 20));
            Console.WriteLine("Der Aufruf mit drei int-Argumenten: {0}", Produkt.Rechnung(10, 20, 30));

            Console.WriteLine("Der Aufruf mit zwei float-Argumenten: {0}", Produkt.Rechnung((float)10.5, (float)20.5));
            Console.WriteLine("Der Aufruf mit zwei float-Argumenten: {0}", Produkt.Rechnung((float)10.5, (float)20.5));
            Console.WriteLine("Der Aufruf mit zwei float-Argumenten: {0}", Produkt.Rechnung(wert1, wert2));

        }
    }
}
