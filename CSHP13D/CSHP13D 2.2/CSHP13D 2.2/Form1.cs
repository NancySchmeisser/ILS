using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHP13D_2._2
{
    public partial class Form1 : Form
    {
        int zaehler;
        string dateiname;
        public Form1()
        {
            InitializeComponent();
            zaehler = 1;
            string dateiname;
        }

        void NeuesDokument()
        {
            //den Text löschen
            richTextBox1.Clear();
            //die Anzeige in der Titelliste setzen
            this.Text = "ohnename" + zaehler;
            //den Zähler um 1 erhöhen
            zaehler++;
            //der Dateiname ist leer
            dateiname = string.Empty;

        }

        void Speichern(string name)
        {
            dateiname = name;
            //den Text in der Titelleiste setzen
            this.Text = dateiname;
            //die Datei speichern
            richTextBox1.SaveFile(dateiname);
            //es sind keine Änderungen mehr vorhanden
            richTextBox1.Modified = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            NeuesDokument();
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NeuesDokument();
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Speichern(dateiname);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string name;
            //den Namen beschaffen
            name = saveFileDialog1.FileName;
            //und die Datei über die eigene Methode speichern
            Speichern(name);
        }

        private void DateiSpeichern(object sender, EventArgs e)
        {
            //wenn der Dateiname noch leer ist, den Dialog speichern
            //unter aufrufen
            if (dateiname == string.Empty)
            {
                saveFileDialog1.ShowDialog();
            }
            //sonst unter demselben Namen wieder speichern
            else
            {
                Speichern(dateiname);
            }
        }
    }
}
