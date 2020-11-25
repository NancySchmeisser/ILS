using System;

namespace CSHP04D_2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zahlenArray1 = new int[5];
            int[] zahlenArray2 = new int[1];

            int suche, treffer;
            for (int element = 0; element < zahlenArray1.Length; element++)
            {
                Console.WriteLine("Bitte geben Sie einen Wert ein: ");
                zahlenArray1[element] = Convert.ToInt32(Console.ReadLine());
            }

                zahlenArray2 = (int[])zahlenArray1.Clone();

                Array.Sort(zahlenArray2);

                Console.WriteLine("Die sortierte Ausgabe");
                foreach (int element in zahlenArray2)
                    Console.WriteLine("{0}", element);

                Console.WriteLine();

                Console.Write("Nach welcher Zahl soll gesucht werden? ");
                suche = Convert.ToInt32(Console.ReadLine());

                treffer = Array.BinarySearch(zahlenArray2, suche);

                if (treffer < 0)
                    Console.WriteLine("Die Suche ergab keinen Treffer");
                else
                    Console.WriteLine("Das Element {0} befindet sich an der Position {1}.", suche, treffer+1);

                foreach (Int32 element in zahlenArray1)
                    Console.Write("{0}", element);
                Console.WriteLine();

        }
    }
}
