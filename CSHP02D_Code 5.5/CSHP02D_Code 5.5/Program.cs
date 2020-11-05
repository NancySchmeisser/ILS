using System;

namespace CSHP02D_Code_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vereinbarung der Variablen
            int intVariable;
            string stringVariable1, stringVariable2;

            //Wertzuweisungen
            stringVariable1 = "10";
            stringVariable2 = "20";

            //SO GEHT ES NICHT!
            //intVariable = (int)(stringVariable1) +
            //(int)(stringVariable2);

            //aber so
            //bitte in einer Zeile eingeben
            intVariable = Convert.ToInt32(stringVariable1) + Convert.ToInt32(stringVariable2);
            Console.WriteLine("Das Ergebnis = {0}", intVariable);
        }
    }
}
