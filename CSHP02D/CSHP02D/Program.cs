/* Arithmetische Operationen */

using System;

namespace CSHP02D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("5 + 9\t\t= ");
            Console.WriteLine(5 + 9);

            Console.Write("5 - 9\t\t= ");
            Console.WriteLine(5 - 9);

            Console.Write("5 * 9\t\t= ");
            Console.WriteLine(5 * 9);

            Console.Write("9 / 5\t\t= ");
            Console.WriteLine(9 / 5);

            Console.Write(" Rest ");
            Console.WriteLine( 9 % 5);

            Console.Write("10 + 8 /2\t\t= ");
            Console.WriteLine(10 + 8 / 2);

            //Geänderte Reihenfolge durch Klammern

            Console.Write("(10 + 8) / 2\t\t= ");
            Console.WriteLine((10 + 8) / 2);

            Console.WriteLine("5 + 9\t\t= {0}", 5 + 9);





        }
    }
}
