/* #################################################### 
Einsendeaufgabe 3.2 
#################################################### */


using System;

namespace Einsendeaufgabe_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
         
            for (int i = 1; i <= 5; i++)
            {
                if (i != 1)
                    Console.Write(",");
                Console.Write("{0}", i);
            }
        }
    }
}
