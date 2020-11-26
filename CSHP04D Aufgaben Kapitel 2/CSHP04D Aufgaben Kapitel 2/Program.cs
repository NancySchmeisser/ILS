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
            float[] testArray = new float[5];
            Eingabe(testArray);
        }
    }
}
