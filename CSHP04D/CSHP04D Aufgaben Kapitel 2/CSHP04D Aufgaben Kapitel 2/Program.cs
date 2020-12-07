using System;

namespace CSHP04D_Aufgaben_Kapitel_2
{
    class Program
    {

        static void Eingabe(float[] argArray)
        {
            for(int i = 0; i < argArray.Length; i++) 
            {
                Console.WriteLine("{0}", i + 1);
            }
        }
        static void Main(string[] args)
        {
            // float[] testArray = new float[5];
            // Eingabe(testArray);

            int[,,] r =
            {
                {
                    { 1, 4, 6, 7 },
                    { 2, 4, 0, 9 },
                    { -4, 3, 6, 7 },
                },
                {
                    { 5, 7, 8, -2 },
                    { -3, 22, 6, 4 },
                    { 0, -3, 2, 4 },
                }
            };

            Console.WriteLine(r[0, 2, 3]);
        
        }
    }
}
