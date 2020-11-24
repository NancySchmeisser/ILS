using System;

namespace CSHP04D_2._5
{
    class Program
    {
        static void Eingabe(int[] argArray)
        {
            for (int index = 0; index < argArray.Length; index++)
            {
                Console.Write("Bitte geben Sie die {0}. Zahl ein: ", index + 1);
                argArray[index] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void Quadrat(int[] argArray)
        {
            foreach (int element in argArray)
                Console.WriteLine("Das Quadrat von {0} ist: {1}", element, element * element);
        }

        static void Main (string[] args)
        {
            int[] zahlenArray = new int[5];
            Eingabe(zahlenArray);
            Quadrat(zahlenArray);
        }
    }
}
