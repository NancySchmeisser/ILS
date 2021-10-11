namespace CSHP11D_2
{
    internal class Score
    {
        internal int punkte;

        public Score()
        {
            punkte = 0;
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
}
