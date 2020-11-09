/* #################################################
Einsendeaufgabe 2.4
################################################# */

using System;

namespace Aufgabe0204
{
	class Program
	{
		static void Main(string[] args)
		{
			int variable;
            const int minutenProStunde = 60;
			const int stundenProTag = 24;
			const int tageProWoche = 7;

            variable = minutenProStunde;
			//bitte in einer Zeile eingeben
			Console.WriteLine("Eine Stunde hat {0} Minuten.", variable);
			variable = minutenProStunde * stundenProTag;
			Console.WriteLine("Ein Tag hat {0} Minuten.", variable);
			variable = minutenProStunde * stundenProTag * tageProWoche;
			//bitte in einer Zeile eingeben
			Console.WriteLine("Eine Woche hat {0} Minuten.", variable);
		}
	}
}
