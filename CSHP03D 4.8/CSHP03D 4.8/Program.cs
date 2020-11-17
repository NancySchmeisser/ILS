using System;

namespace CSHP03D_4._8
{
    class Program
    {
       static int Summe (int x, int y )
        {
            
            return (x + y);
        }
        static void Main (String[] args)
        {
            int einVariable1, einVariable2;

            Console.Write("Geben Sie die erste Zahl ein: ");
            einVariable1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geben Sie die zweite Zahl ein: ");
            einVariable2 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Die Summe der beiden Zahlen ist {0}", Summe(einVariable1, einVariable2));
        }
    }
}
