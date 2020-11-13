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
            int schleifenVariable = 10;



            while (schleifenVariable <= 20)
            {
                Console.WriteLine("{0}", schleifenVariable);
                schleifenVariable++;
            }
        }
    }
}
