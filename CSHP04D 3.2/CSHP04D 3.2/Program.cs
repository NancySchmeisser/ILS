using System;

namespace CSHP04D_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string zKette2;
            string zKette1 = "Rätsel";

            do
            {
                Console.Write("Raten Sie. Wie heißt das Wort? ");
                zKette2 = Console.ReadLine();
            } while (zKette2 == String.Empty);

            if (zKette1 == zKette2)
                Console.WriteLine("Sie haben richtig geraten.");
            else
                Console.WriteLine("Leider falsch");
        }
    }
}
