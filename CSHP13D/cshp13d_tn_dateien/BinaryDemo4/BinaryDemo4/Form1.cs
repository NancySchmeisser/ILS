using System;
using System.Windows.Forms;
using System.IO;

namespace BinaryDemo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSuche_Click(object sender, EventArgs e)
        {
            string dateiname;
            int treffer = 0;
            int punkte = 0;
            int neuePosition = 0;
            string name;
            //die Liste leeren
            listBox1.Items.Clear();
            //ist das Suchkriterium leer?
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("Bitte geben Sie ein Suchkriterium ein.");
                //den Focus auf das Eingabefeld setzen
                textBox1.Select();
                return;
            }
            //den Namen für die Datei zusammenbauen
            dateiname = Application.StartupPath + "\\score.dat";
            //existiert die Datei?
            if (File.Exists(dateiname) == false)
            {
                MessageBox.Show("Die Datei score.dat ist nicht vorhanden!");
                return;
            }
            else
            {
                //die Datei öffnen
                using (FileStream fStream = new FileStream(dateiname, FileMode.Open))
                {
                    using (BinaryReader binaerDatei = new BinaryReader(fStream))
                    {
                        //die gesamte Datei durchsuchen
                        while (fStream.Position < fStream.Length)
                        {
                            //die erste Punktzahl lesen
                            punkte = binaerDatei.ReadInt32();
                            //stimmt die Punktzahl mit dem Suchkriterium überein?
                            if (punkte == Convert.ToInt32(textBox1.Text))
                            {
                                //den Wert für Treffer erhöhen
                                treffer++;
                                //den Namen lesen
                                name = binaerDatei.ReadString();
                                //und in der Liste ausgeben
                                listBox1.Items.Add(name);
                            }
                            //stimmt das Suchkriterium nicht, dann den Namen überlesen
                            else
                            {
                                //die Länge beschaffen
                                neuePosition = binaerDatei.ReadByte();
                                //und die neue Position ansteuern
                                fStream.Position = fStream.Position + neuePosition;
                            }
                        }
                    }
                }
                //wenn kein Treffer, eine Meldung in der Liste erzeugen
                if (treffer == 0)
                    listBox1.Items.Add("Kein Treffer gefunden");
            }
        }

        private void ButtonBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
