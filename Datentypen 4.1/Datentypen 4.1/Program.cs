using System;

namespace Datentypen_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vereinbarung der Variablen
            byte byteVariable = 255;
            sbyte sbyteVariable = 1;
            short int16Variable = 1;
            ushort uInt16Variable = 1;
            int int32Variable = 1;
            uint uInt32Variable = 1;
            long int64Variable = 1;
            ulong uInt64Variable = 1;

            //Ausgabe der Tabelle
            //bitte jeweils in einer Zeile eingeben
            Console.WriteLine("{0}\tvon {1} bis {2}",
                byteVariable.GetType(), byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0}\tvon {1} bis {2}",
               sbyteVariable.GetType(), sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("{0}\tvon {1} bis {2}",
                int16Variable.GetType(), short.MinValue, short.MaxValue);
            Console.WriteLine("{0}\tvon {1} bis {2}",
                uInt16Variable.GetType(), ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("{0}\tvon {1} bis {2}",
                int32Variable.GetType(), int.MinValue, int.MaxValue);
            Console.WriteLine("{0}\tvon {1} bis {2}",
                uInt32Variable.GetType(), uint.MinValue, uint.MaxValue);
            Console.WriteLine("{0}\tvon {1} bis {2}",
                int64Variable.GetType(), long.MinValue, long.MaxValue);
            Console.WriteLine("{0}\tvon {1} bis {2}",
                uInt64Variable.GetType(), ulong.MinValue, ulong.MaxValue);

            //bitte in einer Zeile eingeben
            Console.WriteLine("Die Variable hat den Wert: {0}", byteVariable);
            //jetzt erhöhen wir den Wert um 1 über den
            //Inkrement Operator
            byteVariable++;
            //bitte in einer Zeile angeben
            Console.WriteLine("255 + 1 ist gleich {0}????", byteVariable);
        }
    }
}
