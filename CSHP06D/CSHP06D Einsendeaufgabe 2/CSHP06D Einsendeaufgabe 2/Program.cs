using System;

namespace CSHP06D_Einsendeaufgabe_2
{

    class Katze
    {
        int groesse;

        public Katze(int groesse)
        {
            this.groesse = groesse;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
     //       Katze kleineKatze = new Katze();
        }
    }
}

//Die Ausführung funktioniert nicht. („There is no argument given that corresponds tot he required formal parameter „groesse“ of Katze.Katze(int)“
//In der Klasse Katze wurde ein eigener Konstruktor erstellt, damit wird kein Standardkonstruktor angelegt.. In der Instanz der Klasse Katze wird der nicht mehr vorhandene Standardkonstruktor aufgerufen, was dann nicht funktionert.
