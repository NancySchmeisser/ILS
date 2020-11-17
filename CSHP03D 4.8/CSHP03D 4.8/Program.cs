using System;
using System.Linq;

namespace CSHP03D_4._8
{
    class Program
    {
        static int Produkt(int a, int b)
        {

            return (a * b);
        }

        static int Quadrat(int x)
        {

            return Produkt(x,x);
        }
        static void Main (String[] args)
        {

            int einVariable1;

            Console.Write("Geben Sie die Zahl ein: ");
            einVariable1 = Convert.ToInt32(Console.ReadLine());

          

            Console.WriteLine("Das Quadrat der Zahl ist {0}", Quadrat(einVariable1));
        }
    }
}
