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


            Console.Write("Geben Sie eine Jahreszahl ein: ");
            jahresZahl = Convert.ToInt32(Console.ReadLine());

            if (jahresZahl % 4 != 0)
                Console.WriteLine("Dieses Jahr ist kein Schaltjahr");
            else if ((jahresZahl % 4 == 0) && (jahresZahl % 100 != 0))
                Console.WriteLine("Das Jahr {0} IST ein Schaltjahr!", jahresZahl);

            else if ((jahresZahl % 4 == 0) && (jahresZahl % 100 == 0) && (jahresZahl % 400 != 0))
                Console.WriteLine("Dieses Jahr ist kein Schaltjahr");
            else 
                Console.WriteLine("Das Jahr {0} IST ein Schaltjahr!", jahresZahl);



        }
    }
}
