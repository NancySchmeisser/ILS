using System;

namespace CSHP04D_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aArray;
            int[] bArray = new int[5];

            for (int element = 0; element < bArray.Length; element++)
            bArray[element] = 5 * element;

            aArray = bArray;
            Console.WriteLine("Die Werte in aArray sind:");
            foreach (int element in aArray)
                Console.WriteLine("{0}", element);

            Console.WriteLine("Die Werte in bArray sind:");
            foreach (int element in bArray)
                Console.WriteLine("{0}", element);

            aArray[0] = 200;
            bArray[4] = 1000;

            Console.WriteLine("Die Werte in aArray sind:");
            foreach (int element in aArray)
                Console.WriteLine("{0}", element);

            Console.WriteLine("Die Werte in bArray sind:");
            foreach (int element in bArray)
                Console.WriteLine("{0}", element);
        }
    }
}
