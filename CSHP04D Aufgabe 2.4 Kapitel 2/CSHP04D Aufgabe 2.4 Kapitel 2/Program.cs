using System;

namespace CSHP04D_Aufgabe_2._4_Kapitel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] test = {5, 7, 6, 8, 3, 9, 4, 1, 2, 0};

            foreach (float element in test)
                Console.WriteLine("Der Wert ist {0}", element);

        }
    }
}
