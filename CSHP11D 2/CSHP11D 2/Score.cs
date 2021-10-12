namespace CSHP11D_2
{
   
    internal class Score
    {
        internal int punkte;
        //die Anzahl der Einträge in der Liste
        int anzahl = 10;
        //für die Liste
        Liste[] bestenliste;

        public Score()
        {
            punkte = 0;
            //eine neue Instanz der Liste erstellen
            bestenliste = new Liste[anzahl];
            //die Elemente initialisieren
            for (int i = 0; i < anzahl; i++)
            {
                bestenliste[i] = new Liste();
            }
        }

        public int VeraenderePunkte(int anzahl)
        {
            punkte = punkte + anzahl;
            return punkte;
        }

        public void LoeschePunkte()
        {
            punkte = 0;
        }
    }

    //die Klasse für die Liste
    //Sie muss die Schnittstelle iComparable implementieren
    public class Liste : System.IComparable
    {
        //die Felder
        int listePunkte;
        string listeName;


        //die Methoden
        //der Kosntruktor
        public Liste()
        {
            //er setzt die punkte und den Namen auf
            //Standardwerte
            listePunkte = 0;
            listeName = "Nobody";
        }

        //Die Vergleichsmethode
        public int CompareTo(object objekt)
        {
            Liste tempListe = (Liste)(objekt);
            if (this.listePunkte < tempListe.listePunkte)
                return 1;
            if (this.listePunkte > tempListe.listePunkte)
                return -1;
            else
                return 0;
        }

        //die Methode zum Setzen von Einträgen
        public void SetzeEintrag(int punkte, string name)
        {
            listePunkte = punkte;
            listeName = name;
        }

        //die Methode zum Liefern der Punkte
        public int GetPunkte()
        {
            return listePunkte;
        }

        //die Methode zum Liefern des Namens
        public string GetName()
        {
            return listeName;
        }
    }
}
