/* #################################################### 
Einsendeaufgabe 3.3 
#################################################### */


using System;

namespace Einsendeaufgabe_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int schleifenVariable = 1;

            while (schleifenVariable <= 25)
            {
                Console.WriteLine("Zahl = \t {0}", schleifenVariable *2);
                schleifenVariable++;
            }
        }
    }
}
