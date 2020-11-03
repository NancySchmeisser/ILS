using System;

namespace Gleitkommazahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vereinbarung der Variablen
            float floatVariable;
            double doubleVariable;

            //Ausgabe von Gleitkommazahlen mit Standardeinstellungen

            Console.WriteLine("Ausgabe von Gleitkommazahlen:");
            Console.WriteLine("Standardeinstellungen");
            Console.WriteLine("=============================");
            floatVariable = 10000000000;
            //bitte jeweils in einer Zeile eingeben
            Console.WriteLine("Große Zahlen (10000000000): {0}", floatVariable);
            Console.WriteLine("Kommazahlen (1.33333333333333333333)");
            floatVariable = 1.33333333333333333333F;
            Console.WriteLine("Als float: {0}", floatVariable);
            doubleVariable = 1.33333333333333333333;
            Console.WriteLine("Als double : {0}", doubleVariable);
            //Ausgabe von Gleitkommazahlen mit geänderten Einstellungen
            Console.WriteLine("\n\n18 Stellen");
            Console.WriteLine("=============================");
            floatVariable = 10000000000;
            //bitte in einer Zeile eingeben
            Console.WriteLine("Große Zahlen (10000000000):{0:G18}", floatVariable);
            Console.WriteLine("Kommazahlen (1.33333333333333333333)");
            floatVariable = 1.33333333333333333333F;
            Console.WriteLine("Als float: {0:G18}", floatVariable);
            Console.WriteLine("Als double: {0:G18}", doubleVariable);
            //jetzt verändert sich die Genauigkeit der Nachkommastellen
            floatVariable = 1001.33333333333333333333F;
            Console.WriteLine("Als float: {0:G18}", floatVariable);
            Console.WriteLine("Große Zahlen (10000000000) : {0:N0}", floatVariable);
            Console.WriteLine("Große Zahlen (10000000000) : {0,20:N0}", floatVariable);
        }
    }
}
