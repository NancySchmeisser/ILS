/* ########################
 continue in einer Schleife
##########################*/

using System;

namespace CSHP03D_3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, k;
            bool flagVariable = true;
            i = 0;
            k = 0;


            while (i <= 5 && (flagVariable == true))
            {
                Console.Write("Geben Sie eine 1 zum Abbruch ein.");
                k = Convert.ToInt32(Console.ReadLine());
                if (k == 1)
                    flagVariable = false;
                else
                {
                    i++;
                }
              
            }
            Console.WriteLine("Schleife beendet.");
        }
    }
}
