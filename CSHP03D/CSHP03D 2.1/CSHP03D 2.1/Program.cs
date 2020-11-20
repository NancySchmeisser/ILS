/* ########################
  Einfache if-Verzweigung
##########################*/

using System;

namespace CSHP03D_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("Bitte geben Sie X ein: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitte geben Sie Y ein: ");
            y = Convert.ToInt32(Console.ReadLine());


            if (x > y)
            

                Console.WriteLine("X ist größer als Y.");
               else
                if (x < y)
                    Console.WriteLine("X ist kleiner als Y."); 
                else
                Console.WriteLine("X ist gleich Y");
            Console.WriteLine("Die Zahlen waren {0} und {1}.", x, y);
        }
    }
}