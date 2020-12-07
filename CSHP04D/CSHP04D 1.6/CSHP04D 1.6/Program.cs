using System;

namespace CSHP04D_1._6
{
    class Program
    {
       static void ErhoeheA(int a)
        {
            a = a + 1;
        }

        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine("Die Variable hat den Wert {0}", a);
            ErhoeheA(a);
            Console.WriteLine("Die Variable hat den Wert {0}", a);
        }
    }
}
