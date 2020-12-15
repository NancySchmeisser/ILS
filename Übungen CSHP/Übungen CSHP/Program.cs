using System;

namespace Übungen_CSHP
{
    class Program
    {
        static void Main(string[] args)
        {

           bool prüfVariable = false;

            Console.WriteLine("Bitte geben Sie eine Jahreszahl ein, um zu überprüfen, ob es ein Schaltjahr ist.");
           int jahresZahl = Convert.ToInt32(Console.ReadLine());

            if ((jahresZahl % 4 == 0) && (jahresZahl % 100 != 0))
                prüfVariable = true;

            if ((jahresZahl % 4 == 0) && (jahresZahl % 100 == 0) && (jahresZahl % 400 == 0))
                prüfVariable = true;

            if (prüfVariable == true)
                Console.WriteLine("Dieses Jahr ist ein Schaltjahr!");
            else
                Console.WriteLine("Dieses Jahr ist KEIN Schaltjahr!");



        }
    }
}
