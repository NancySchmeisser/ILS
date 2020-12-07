using System;

namespace CSHP04D_4._3
{
    class Program
    {
       
        
            enum Tage { Montag, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag};

        static void Main(string[] args)
        {
            Tage meineWoche;

            meineWoche = Tage.Montag;

            if (meineWoche == Tage.Montag)
                Console.WriteLine("Heute ist Montag");
            else
                Console.WriteLine("Heute ist kein Montag");
        }
    }
}
