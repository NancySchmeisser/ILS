using System;

namespace CSHP04D_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string zKette1 = " Rätsel ";

            Console.WriteLine(zKette1);
            zKette1 = zKette1.Trim();
            Console.WriteLine(zKette1);

            zKette1 = zKette1.Trim('R', 'l');
            Console.WriteLine(zKette1);

            zKette1 = zKette1.Insert(0, "R");
            Console.WriteLine(zKette1);

            zKette1 = zKette1.Insert(zKette1.Length, "l");
            Console.WriteLine(zKette1);

            zKette1 = zKette1.ToUpper();
            Console.WriteLine(zKette1);

            zKette1 = zKette1.ToLower();
            Console.WriteLine(zKette1);


        }
    }
}
