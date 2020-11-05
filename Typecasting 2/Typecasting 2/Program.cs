using System;

namespace Typecasting_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vereinbarung der Variablen
            int intVariable1, intVariable2;
            double doubleVariable1, doubleVariable2, doubleVariable3;

            //Wertzuweisungen
            intVariable1 = 10;
            doubleVariable1 = 1.444444444444444;
            intVariable2 = 3;
            doubleVariable2 = 3;

            //beide double werden zum int, das Ergebnis wird falsch
            //bitte jweils in einer Zeile eingeben
           //doubleVariable3 = (int)doubleVariable1 / (int)doubleVariable2;
            //Console.WriteLine("(int) double / (int) double = {0}", doubleVariable3);

            //ein int wird zum double, das Ergebnis stimmt
            doubleVariable3 = (double)intVariable1 / intVariable2;
            Console.WriteLine("(double)int / int = {0}", doubleVariable3);

            //noch einmal zur Kontrolle ohne Casting, das
            //Ergebnis ist wieder falsch

            doubleVariable3 = intVariable1 / intVariable2;
            Console.WriteLine("int / int = {0}", doubleVariable3);

            //der gesamte Ausdruck wird gecastet
            doubleVariable3 = (double) (intVariable1 / intVariable2);

            //bitte in einer Zeile eingeben
            Console.WriteLine("(double)  (int / int) = {0}", doubleVariable3);

            //float float1 = doubleVariable1;
            //Aufgaben
            Console.WriteLine("Ergebnis = {0}", (float)doubleVariable1);

        }
    }
}