using System;

namespace CSHP04D_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zahlen = new int[10];
            for (int element = 0; element < zahlen.Length; element++)
            zahlen[element] = element * element;
            foreach (int element in zahlen)
                Console.WriteLine("Der Wert ist {0}.", element);
        }
    }
}
