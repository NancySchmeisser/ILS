/* Textausgabe mit und ohne Zeilenumbruch */

using System;

namespace CSHP02D
{
    class Program
    {
        static void Main(string[] args)
        {
            //bitte in einer Zeile eingeben
            Console.Write("Texztausgabe in C#, \nohne einen Zeilenumbruch\n");
            Console.Write("Textausgabe\t in C#,");
            Console.Write("ohne einen Zeilenumrbuch");
            Console.WriteLine("Textausgabe\r in C#,");
            Console.WriteLine("mit Zeilenumbruch");
            Console.WriteLine("Anfang \"Mitte\" Ende");

           
             
        }
    }
}
