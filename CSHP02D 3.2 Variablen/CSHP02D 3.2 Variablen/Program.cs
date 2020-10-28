/* Variablen Einführung */

using System;

namespace CSHP02D_3._2_Variablen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vereinbarung der Variablen
            int zahl1 = 1;
            int zahl2, zahl3, zahl4;
            //Zuweisungen
            //zahl2 erhält das Ergebnis des Audrucks 1+1, also 2
            zahl2 = 1 + 1;
            //zahl3 erhält den aktuellen Wert von Zahl2 * 5, also
            //10
            zahl3 = zahl2 * 5;

            //Ausgaben
            Console.WriteLine("zahl1 hat den Wert {0}", zahl1);
            Console.WriteLine("zahl2 hat den Wert {0}", zahl2);
            Console.WriteLine("zahl3 hat den Wert {0}", zahl3);

            //Hier beginnt der Ringtausch
            //Die Werte von zahl1 und zahl2 werden getauscht
            //Zuerst wird der Wert von zahl1 in zahl4 gesichert
            zahl4 = zahl1;
            //dann erhält zahl1 den Wert von zahl2
            zahl1 = zahl2;
            //und zum Schluss wird zahl2 der gesicherte
            //Wert von zahl4 zugewiesen
            zahl2 = zahl4;

            //Ausgaben nach dem Tausch
            Console.WriteLine("zahl1 hat jetzt den Wert {0}", zahl1);
            Console.WriteLine("zahl2 hat jetzt den Wert {0}", zahl2);



        }
    }
}
