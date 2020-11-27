using System;
using System.Text;

namespace CSHP04D_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder zKette = new StringBuilder("Rätsel");
            Console.WriteLine("{0}", zKette);

            zKette.Append("haft ist manches Mal das Programmieren.");
            Console.WriteLine("{0}", zKette);

            zKette[0] = 'A';
            Console.WriteLine("{0}", zKette);
        }
    }
}
