/* Der Datentyp bool */

using System;

namespace Datentyp_für_logische_Werte
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vereinbarung der Variablen
            bool boolVariable;

            //Werte zuweisen und ausgeben
            boolVariable = true;
            Console.WriteLine("Der Wert: {0}", boolVariable);

            boolVariable = false;
            Console.WriteLine("Der Wert: {0}", boolVariable);
        }
    }
}
