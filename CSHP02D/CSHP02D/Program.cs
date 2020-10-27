/* Arithmetische Operationen */

using System;

namespace CSHP02D
{
    class Program
    {
        static void Main(string[] args)
        {  

            Console.WriteLine("5 + 9\t\t= {0}", 5 + 9);
            Console.WriteLine("5 - 9\t\t= {0}", 5 -9);
            Console.WriteLine("5 * 9\t\t= {0}", 5 * 9);

            // Ausgabe mit 2 Platzhaltern

            Console.WriteLine("9 / 5\t\t= {0} Rest {1}", 9 / 5, 9 % 5);
            Console.WriteLine("10 + 8 /2\t\t= {0}", 10 + 8 / 2);
            
            // Geänderte Reihenfolge durch Klammern

            Console.WriteLine("(10 + 8) / 2\t\t= {0}", (10 + 8) / 2);
            Console.WriteLine("9 / 5 ergibt als Rest {1} und als Ergebnis {0}", 9 / 5, 9 % 5);           
        }
    }
}
