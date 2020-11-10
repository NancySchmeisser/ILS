/* ##################################
 Logisches UND
##################################### */

using System;

namespace CSHP03D_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A \t B \t\t A && B");
            Console.WriteLine("wahr \t wahr \t\t {0}", (true && true));
            Console.WriteLine("wahr \t falsch \t\t {0}", (true && false));
            Console.WriteLine("falsch \t wahr \t\t {0}", (false && true));
            Console.WriteLine("falsch \t falsch \t\t {0}", (false && false));
        }
    }
}