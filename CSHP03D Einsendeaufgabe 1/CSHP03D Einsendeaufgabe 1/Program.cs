/* #################################################### 
Einsendeaufgabe 3.1 
#################################################### */


using System;

namespace CSHP03D_Einsendeaufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int jahresZahl;
            bool istSchaltjahr = false;

            Console.Write("Geben Sie eine Jahreszahl ein: ");
            jahresZahl = Convert.ToInt32(Console.ReadLine());

            if (jahresZahl % 4 == 0)
                istSchaltjahr = true;

            if (jahresZahl % 100 == 0)
                istSchaltjahr = false;

            if (jahresZahl % 400 == 0)
                istSchaltjahr = true;


            if (istSchaltjahr == true)
                Console.WriteLine("Das Jahr {0} IST ein Schaltjahr!", jahresZahl);
            else
                Console.WriteLine("Das Jahr {0} ist KEIN Schaltjahr!", jahresZahl);
        }
    }
}
