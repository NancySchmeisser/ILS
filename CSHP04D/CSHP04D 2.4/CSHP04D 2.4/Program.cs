using System;

namespace CSHP04D_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tabellenArray1 = { { 3, 5, 7, 6 }, {2, 1, 0, 9 } };

            int[,] tabellenArray2;
            tabellenArray2 = new int[4, 3];
            foreach (int element in tabellenArray1)
                Console.WriteLine("Der Wert ist {0}", element);

            Console.WriteLine();

            tabellenArray2[1, 1] = 10;
            foreach (int element in tabellenArray2)
                Console.WriteLine("Der Wert ist {0}", element);
        }

      }
}
