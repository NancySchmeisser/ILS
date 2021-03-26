using System;

namespace CSHP09D_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1, zahl2, ergebnis;
            Console.Write("Zahl 1:");
            zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zahl 2:");
            zahl2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                ergebnis = zahl1 / zahl2;
            }

            catch (System.SystemException)
            {
                Console.WriteLine("Ein Fehler ist aufgetreten");
                Console.WriteLine("Ergebnis erhält den Wert 0.");
                ergebnis = 0;
            }
            Console.WriteLine("Das Ergebnis ist {0}", ergebnis);
        }
    }
}
