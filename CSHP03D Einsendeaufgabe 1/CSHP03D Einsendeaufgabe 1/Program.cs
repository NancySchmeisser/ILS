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
            bool flagVariable = false;


            Console.Write("Geben Sie eine Jahreszahl ein: ");
            jahresZahl = Convert.ToInt32(Console.ReadLine());

            if ((jahresZahl % 4 != 0))
                flagVariable = false;

            else if ((jahresZahl % 4 == 0) && (jahresZahl % 100 != 0))
                flagVariable = true;


            else if ((jahresZahl % 4 == 0) && (jahresZahl % 100 == 0) && (jahresZahl % 400 != 0))
                flagVariable = false;

            else Console.WriteLine("Wert ist nicht gültig"); 


            if (jahresZahl == 0)
                flagVariable = false;
            else
            {
                Console.WriteLine("Das Jahr {0} IST ein Schaltjahr!", jahresZahl);
            }
        }
    }
}
