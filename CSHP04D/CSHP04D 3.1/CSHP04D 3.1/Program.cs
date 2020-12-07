using System;

namespace CSHP04D_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string zKette1;
            string zKette2;
            string zKette3;

            zKette1 = "Ich bin";
            zKette2 = " eine Zeichenkette";

            zKette3 = zKette1 + zKette2;

            Console.WriteLine("Die Zeichenkette enthält {0} Zeichen.", zKette3.Length);

            for (int index = 0; index < zKette3.Length; index++)
                Console.Write(" {0}", zKette3[index]);
            Console.WriteLine();

            foreach (char zeichen in zKette3)
                Console.Write("{0}", zeichen);
            Console.WriteLine();

        }
    }
}
