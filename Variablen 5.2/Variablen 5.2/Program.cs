using System;

namespace Variablen_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            long longZahl = 1234567891234567;
            int intZahl = 100;
            double doubleZahl = 1.2;
            byte byteZahl = 10;
            //diese Zuweisungen sind möglich
            longZahl = intZahl;
            doubleZahl = intZahl;
            doubleZahl = longZahl;
            longZahl = byteZahl;
            //diese dagegen nicht
            //intZahl = longZahl;
            //intZahl = doubleZahl;
            //byteZahl = intZahl;



        }
    }
}
