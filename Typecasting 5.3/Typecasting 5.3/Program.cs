using System;

namespace Typecasting_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vereinbarung der Variablen
            int intVariable1, intVariable2;
            double doubleVariable1, doubleVariable2, doubleVariable3;

            //Wertzuweisungen
            intVariable1 = 10;
            doubleVariable1 = 10;
            intVariable2 = 3;
            doubleVariable2 = 3;

            //double / double
            doubleVariable3 = doubleVariable1 / doubleVariable2;
            Console.WriteLine("double / double = {0}", doubleVariable3);

            //int / double
            doubleVariable3 = intVariable1 / doubleVariable2;
            Console.WriteLine("int / double = {0}", doubleVariable3);

            //double / int
            doubleVariable3 = doubleVariable1 / intVariable2;
            Console.WriteLine("double / int = {0}", doubleVariable3);

            //int / int
            doubleVariable3 = intVariable1 / intVariable2;
            Console.WriteLine("int / int = {0}", doubleVariable3);
        }
    }
}
