using System;
using System.Drawing;
using System.Xml;

namespace Pong
{
    

    internal class Score
    {
        internal int punkte;

        internal int anzahl = 10;

        internal Liste[] bestenliste;

        string xmlDateiname;

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
            //den Dateinamen aus dem Pfad zusammenbauen
            xmlDateiname = System.Windows.Forms.Application.StartupPath + "\\score.xml";
            //wenn es die Datei schon gibt, die Daten lesen
            if (System.IO.File.Exists(xmlDateiname))
                LesePunkte();
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

        public bool NeuerEintrag()
        {
            string tempName = string.Empty;
            //wenn die aktuelle Punktzahl größer ist als der
            //letzte Eintrag der Liste, wird der letzte Eintrag
            //der Liste überschrieben und die Liste neu sortiert
            if (punkte > bestenliste[anzahl - 1].GetPunkte())
            {
                //den Namen beschaffen
                NameDialog neuerName = new NameDialog();
                if (neuerName.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    tempName = neuerName.LiefereName();
                neuerName.Close();
                bestenliste[anzahl - 1].SetzeEintrag(punkte, tempName);
                Array.Sort(bestenliste);
                return true;
            }
            else
                return false;
        }

        public void ListeAusgeben(Graphics zeichenflaeche, RectangleF flaeche, Color hintergrundFarbe, Color schriftFarbe)
        {
            //ein temporärer Pinsel
            SolidBrush tempPinsel = new SolidBrush(schriftFarbe);
            //die Schriftart setzen
            Font tempSchrift = new Font("Arial", 12, FontStyle.Bold);
            //für die zentrierte Ausgabe
            StringFormat ausrichtung = new StringFormat();
            //Koordinaten für die Ausgabe
            float punkteX, nameX, y;
            punkteX = flaeche.Left + 50;
            nameX = flaeche.Left + 250;
            y = flaeche.Top + 50;
            //die Ausrichtung ist zentriert
            ausrichtung.Alignment = StringAlignment.Center;
            //die Zeichenfläche löschen
            zeichenflaeche.Clear(hintergrundFarbe);
            //den Titel ausgeben
            zeichenflaeche.DrawString("Bestenliste", tempSchrift, tempPinsel, flaeche.Width / 2, y, ausrichtung);
            //und nun die Liste selbst
            for (int i = 0; i < anzahl; i++)
            {
                y = y + 20;
                zeichenflaeche.DrawString(Convert.ToString(bestenliste[i].GetPunkte()), tempSchrift, tempPinsel, punkteX, y);
                zeichenflaeche.DrawString(bestenliste[i].GetName(), tempSchrift, tempPinsel, nameX, y);
            }
        }

        //zum Lesen aus der Datei
        void LesePunkte()
        {
            //zum Zwischenspeichern der gelesenen Daten
            int tempPunkte;
            string tempName;
            //eine Instanz von XmlReader erzeugen
            XmlReader xmlLesen = XmlReader.Create(xmlDateiname);
            //die Daten in einer Schleife lesen und zuweisen
            for (int i = 0; i < anzahl; i++)
            {
                xmlLesen.ReadToFollowing("name");
                tempName = xmlLesen.ReadElementString();
                xmlLesen.ReadToFollowing("punkte");
                tempPunkte = Convert.ToInt32(xmlLesen.ReadElementString());
                bestenliste[i].SetzeEintrag(tempPunkte, tempName);
            }
            //die Datei wieder schließen
            xmlLesen.Close();
        }

        //zum Schreiben in die Datei
        void SchreibePunkte()
        {
            //die Einstellungen setzen
            XmlWriterSettings einstellungen = new XmlWriterSettings();
            einstellungen.Indent = true;
            //eine Instanz für XmlWriter erzeugen
            XmlWriter xmlSchreiben = XmlWriter.Create(xmlDateiname, einstellungen);
            //die Deklaration schreiben
            xmlSchreiben.WriteStartDocument();
            //den Wurzelknoten bestenliste erzeugen
            xmlSchreiben.WriteStartElement("bestenliste");
            //die Daten in einer Schleife wegschreiben
            for (int i = 0; i < anzahl; i++)
            {
                //den Knoten eintrag erzeugen
                xmlSchreiben.WriteStartElement("eintrag");
                //die Einträge schreiben
                xmlSchreiben.WriteElementString("name", bestenliste[i].GetName());
                xmlSchreiben.WriteElementString("punkte", Convert.ToString(bestenliste[i].GetPunkte()));
                //den Knoten abschließen
                xmlSchreiben.WriteEndElement();
            }
            //alle abschließen
            xmlSchreiben.WriteEndDocument();
            //Datei schließen
            xmlSchreiben.Close();
        }

        public class Liste : IComparable
        {
            internal int listePunkte;

            internal string listeName;

            public Liste()
            {
                //er setzt die punkte und den Namen auf
                //Standardwerte
                listePunkte = 0;
                listeName = "Nobody";
            }

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

            public void SetzeEintrag(int punkte, string name)
            {
                listePunkte = punkte;
                listeName = name;
            }

            public int GetPunkte()
            {
                return listePunkte;
            }

            public string GetName()
            {
                return listeName;
            }
        }
    }
}
