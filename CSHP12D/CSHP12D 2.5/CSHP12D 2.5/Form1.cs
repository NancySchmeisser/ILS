namespace CSHP12D_2._5
{
    using System;
    using System.Windows.Forms;
    using System.Xml;

    public partial class Form1 : Form
    {
        internal string xmlName;

        internal bool xmlVorhanden;

        public Form1()
        {
            InitializeComponent();
            //den Namen aus der ausführbaren Datei ableiten
            xmlName = System.IO.Path.ChangeExtension(Application.ExecutablePath, ".xml");
            //prüfen, ob es die Datei bereits gibt
            xmlVorhanden = System.IO.File.Exists(xmlName);
        }

        private void ButtonLesen_Click(object sender, System.EventArgs e)
        {
            //für den booleschen Wert
            bool tempBool;
            //wenn die Datei nicht da ist, verlassen wir die Methode direkt wieder
            if (xmlVorhanden == false)
            {
                MessageBox.Show("Die Datei ist nicht vorhanden");
                return;
            }
            //die Datei öffnen
            XmlReader xmlLesen = XmlReader.Create(xmlName);
            //die Werte für die drei Eingabefelder einlesen
            xmlLesen.ReadToFollowing("wert1");
            textBoxWert1.Text = xmlLesen.ReadElementString();
            xmlLesen.ReadToFollowing("wert2");
            textBoxWert2.Text = xmlLesen.ReadElementString();
            xmlLesen.ReadToFollowing("wert3");
            textBoxWert3.Text = xmlLesen.ReadElementString();
            //den booleschen Wert lesen
            xmlLesen.ReadToFollowing("bool");
            tempBool = Convert.ToBoolean(xmlLesen.ReadElementString());
            //die Datei schließen
            xmlLesen.Close();
            //den RadioButton setzen
            if (tempBool == true)
                radioButtonTrue.Checked = true;
            else
                radioButtonFalse.Checked = true;
        }

        private void ButtonSchreiben_Click(object sender, System.EventArgs e)
        {
            //die Einstellungen setzen
            XmlWriterSettings einstellungen = new XmlWriterSettings();
            einstellungen.Indent = true;
            //die Datei erzeugen
            XmlWriter xmlSchreiben = XmlWriter.Create(xmlName, einstellungen);
            //die Deklaration schreiben
            xmlSchreiben.WriteStartDocument();
            //die Wurzel schreiben
            xmlSchreiben.WriteStartElement("daten");
            //das Unterelement werte schreiben
            xmlSchreiben.WriteStartElement("werte");
            //die Einträge schreiben
            xmlSchreiben.WriteElementString("wert1", textBoxWert1.Text);
            xmlSchreiben.WriteElementString("wert2", textBoxWert2.Text);
            xmlSchreiben.WriteElementString("wert3", textBoxWert3.Text);
            if (radioButtonTrue.Checked == true)
                xmlSchreiben.WriteElementString("bool", "true");
            else
                xmlSchreiben.WriteElementString("bool", "false");
            //das Element werte abschließen
            xmlSchreiben.WriteEndElement();
            //und die Positionsdaten
            xmlSchreiben.WriteStartElement("position");
            xmlSchreiben.WriteElementString("top", Convert.ToString(this.Top));
            xmlSchreiben.WriteElementString("left", Convert.ToString(this.Left));
            xmlSchreiben.WriteElementString("height", Convert.ToString(this.Height));
            xmlSchreiben.WriteElementString("width", Convert.ToString(this.Width));
            //das Schreiben abschließen
            //offene Tags werden automatisch geschlossen
            xmlSchreiben.WriteEndDocument();
            //die Datei schließen
            xmlSchreiben.Close();
            //jetzt ist die Datei vorhanden
            if (xmlVorhanden == false)
            {
                xmlVorhanden = true;
                labelVorhanden.Text = "Ja";
            }
        }

        private void ButtonPosLesen_Click(object sender, EventArgs e)
        {
            //wenn die Datei nicht da ist, verlassen wir die Methode direkt wieder
            if (xmlVorhanden == false)
            {
                MessageBox.Show("Die Datei ist nicht vorhanden");
                return;
            }
            //die Datei öffnen
            XmlReader xmlLesen = XmlReader.Create(xmlName);
            //die Werte einlesen und die Eigenschaften setzen
            xmlLesen.ReadToFollowing("top");
            //bitte jeweils in einer Zeile eingeben
            this.Top = Convert.ToInt32(xmlLesen.ReadElementString());
            xmlLesen.ReadToFollowing("left");
            this.Left = Convert.ToInt32(xmlLesen.ReadElementString());
            xmlLesen.ReadToFollowing("height");
            this.Height = Convert.ToInt32(xmlLesen.ReadElementString());
            xmlLesen.ReadToFollowing("width");
            this.Width = Convert.ToInt32(xmlLesen.ReadElementString());
            //die Datei schließen
            xmlLesen.Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //die Anzeige in den Labels setzen
            labelName.Text = xmlName;
            if (xmlVorhanden == true)
                labelVorhanden.Text = "Ja";
            else
                labelVorhanden.Text = "Nein";
        }
    }
}
