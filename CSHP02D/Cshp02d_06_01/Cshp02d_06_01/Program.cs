using System;

namespace Cshp02d_06_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vereinbarung der Variablen
            char eingabe1;
            int eingabe2, eingabe3;

            //ein Zeichen über Read() lesen und ausgeben
            //bitte in einer Zeile eingeben
            Console.WriteLine("Geben sie ein Zeichen ein. Drücken sie dann die Eingabetaste");
            eingabe1 = Convert.ToChar(Console.Read());

            //bitte in einer Zeile eingeben
            Console.WriteLine("Sie haben das Zeichen {0} eingegeben", eingabe1);

            //Zahlen einlesen
            //bitte in einer Zeile eingeben
            Console.Write("Geben sie bitte die erste Zahl ein. Drücken Sie dann die Eingabetaste. ");
            eingabe2 = Convert.ToInt32(Console.ReadLine());

            //bitte in einer Zeile eingeben

            Console.Write("Geben sie bitte die zweite Zahl ein. Drücken Sie dann die Eingabetaste. ");
            eingabe3 = Convert.ToInt32(Console.ReadLine());

            //bitte in einer Zeile eingeben
            Console.WriteLine(" Die Addition der Zahlen {0} und {1} ergibt {2}", eingabe2, eingabe3, eingabe2 + eingabe3);

            //Zeichenketten einlesen
            Console.Write("Wie heißen Sie ");
            //eingabe2 = Console.ReadLine();

            Console.Write("Wen wollen sie grüßen? ");
            //eingabe3 = Console.ReadLine();

            //bitte in einer Zeile eingeben
            Console.WriteLine("Hallo {0}. Es grüßt Dich {1}", eingabe3, eingabe2);
        }
    }
}
