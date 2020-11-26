using System;

namespace CSHP04D_Aufgabe_2._4_Kapitel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] test = {5, 7, 6, 8, 3, 9, 4, 1, 2, 0};

            for (int index = 0; index < 10; index++)
            Console.WriteLine("Der Wert des Elements {0} ist: {1}", index, test[index]);

        }
    }
}
