using System;
using System.Linq;

namespace CSHP03D_4._8
{
    class Program
    {
        static int Summe (int x, int y, int z )
        {

            return (x + y + z);
        }
        static void Main (String[] args)
        {
           
            int einVariable1, einVariable2, einVariable3;

            Console.Write("Geben Sie die erste Zahl ein: ");
            einVariable1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geben Sie die zweite Zahl ein: ");
            einVariable2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geben Sie die dritte Zahl ein: ");
            einVariable3 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Die Summe der beiden Zahlen ist {0}", Summe(einVariable1, einVariable2, einVariable3));
        }
    }
}
