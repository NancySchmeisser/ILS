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
			variable = 60;
			//bitte in einer Zeile eingeben
			Console.WriteLine("Eine Stunde hat {0} Minuten.", variable);
			variable = 60 * 24;
			Console.WriteLine("Ein Tag hat {0} Minuten.", variable);
			variable = 60 * 24 * 7;
			//bitte in einer Zeile eingeben
			Console.WriteLine("Eine Woche hat {0} Minuten.", variable);
		}
	}
}
