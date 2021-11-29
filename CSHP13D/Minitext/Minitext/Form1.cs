using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Minitext
{
    public partial class Form1 : Form
    {
        //die eigenen Felder
        //zum Mitzählen
        int zaehler;
        //für den Dateinamen
        string dateiname;

        //die eigenen Methoden
        //zum Erstellen eines neuen Dokuments
        void NeuesDokument()
        {
            //den Text "löschen"
            richTextBox1.Clear();
            //die Anzeige in der Titelleiste setzen
            this.Text = "ohnename" + zaehler;
            //den Zähler um 1 erhöhen
            zaehler++;
            //der Dateiname ist leer
            dateiname = string.Empty;
        }

        //zum Speichern
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


        public Form1()
        {
            InitializeComponent();
        }

        private void NeuToolStripButton_Click(object sender, EventArgs e)
        {
            NeuesDokument();
        }

        private void NeuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NeuesDokument();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            NeuesDokument();
        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string name;
            //den Namen beschaffen
            name = saveFileDialog1.FileName;
            //und die Datei über die eigene Methode speichern
            Speichern(name);
        }

        private void DateiSpeichern(object sender, EventArgs e)
        {
            //wenn der Dateiname noch leer ist, den Dialog Speichern unter aufrufen
            if (dateiname == string.Empty)
                saveFileDialog1.ShowDialog();
            //sonst unter demselben Namen wieder speichern
            else
                Speichern(dateiname);
        }

        private void SpeichernunterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void DateiLaden(object sender, EventArgs e)
        {
            //wenn nicht gespeicherte Änderungen vorliegen
            if (richTextBox1.Modified == true)
            {
                //Meldung mit Ja und Nein erzeugen und überprüfen, ob Ja angeklickt wurde
                if (MessageBox.Show("Wollen Sie die Änderungen speichern?", "Abfrage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    DateiSpeichern(sender, e);
            }
            //den Öffnendialog anzeigen
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //den Namen setzen
            dateiname = openFileDialog1.FileName;
            this.Text = dateiname;
            //die Datei laden
            richTextBox1.LoadFile(dateiname);
            //die Eigenschaft Modified zur Sicherheit auf false setzen
            richTextBox1.Modified = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //wenn nicht gespeicherte Änderungen vorliegen
            if (richTextBox1.Modified == true)
            {
                //Meldung mit Ja, Nein und Abbrechen erzeugen und auswerten
                switch (MessageBox.Show("Wollen Sie die Änderungen speichern?", "Abfrage", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        //das Dokument speichern
                        DateiSpeichern(sender, e);
                        break;
                    case DialogResult.Cancel:
                        //Abbrechen
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void FettToolStripButton_Click(object sender, EventArgs e)
        {
            //fett formatieren
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void KursivToolStripButton_Click(object sender, EventArgs e)
        {
            //kursiv formatieren
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void UnterstreichenToolStripButton_Click(object sender, EventArgs e)
        {
            //fett formatieren
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void ZeichenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //wenn der Dialog Zeichen über OK geschlossen wurde, die Zeichenformatierungen setzen
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void LinksbuendigToolStripButton_Click(object sender, EventArgs e)
        {
            //linksbündig formatieren
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void ZentriertToolStripButton_Click(object sender, EventArgs e)
        {
            //zentriert formatieren
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void RechtsbuendigToolStripButton_Click(object sender, EventArgs e)
        {
            //rechtsbündig formatieren
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void RückgängigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //kann etwas rückgängig gemacht werden?
            if (richTextBox1.CanUndo == true)
                richTextBox1.Undo();
        }

        private void WiederholenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //kann etwas wiederholt werden?
            if (richTextBox1.CanRedo == true)
                richTextBox1.Redo();
        }

        private void AusschneidenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ausschneiden
            richTextBox1.Cut();
        }

        private void KopierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Kopieren
            richTextBox1.Copy();
        }

        private void EinfügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Einfügen
            richTextBox1.Paste();
        }

        private void AlleauswählenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //alles auswählen        
            richTextBox1.SelectAll();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //hat das aktuelle Dokument einen Namen?
            if (dateiname != string.Empty)
            {
                //den Schlüssel HKEY_CURRENT_USER anlegen bzw. öffnen
                using (RegistryKey regSchluessel = Registry.CurrentUser.CreateSubKey("Software\\Minitext"))
                {
                    //den Dateinamen in die Registrierung schreiben
                    regSchluessel.SetValue("Datei", dateiname);
                }
            }
        }

        private void LetzteDatei_Click(object sender, EventArgs e)
        {
            string name;
            //den Namen zurücklesen
            name = ((ToolStripMenuItem)(sender)).Text;
            //die ersten fünf(!!) Zeichen wieder löschen
            name = name.Remove(0, 5);
            //gibt es die Datei noch?
            if (System.IO.File.Exists(name))
            {
                //den Dateinamen setzen
                dateiname = name;
                //in der Titelleiste anzeigen
                this.Text = dateiname;
                //die Datei laden
                richTextBox1.LoadFile(dateiname);
                //die Eigenschaft Modified zur Sicherheit auf false setzen
                richTextBox1.Modified = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //für den Menüeintrag
            ToolStripMenuItem menuEintrag;
            //für den Namen des Eintrags
            string name;
            //den Namen zur Sicherheit leer initialisieren
            name = string.Empty;
            //den Schlüssel HKEY_CURRENT_USER öffnen
            using (RegistryKey regSchluessel = Registry.CurrentUser.OpenSubKey("Software\\Minitext"))
            {
                //ist der Schlüssel vorhanden?
                if (regSchluessel != null)
                {
                    //lesen und zuweisen
                    name = Convert.ToString(regSchluessel.GetValue("Datei"));
                    //den neuen Menüeintrag erzeugen
                    menuEintrag = new ToolStripMenuItem("&1 - " + name, null, new EventHandler(this.LetzteDatei_Click));
                    //und einfügen
                    dateiToolStripMenuItem.DropDownItems.Insert(dateiToolStripMenuItem.DropDownItems.Count - 1, menuEintrag);
                    //und noch eine Trennlinie einfügen
                    dateiToolStripMenuItem.DropDownItems.Insert(dateiToolStripMenuItem.DropDownItems.Count - 1, new ToolStripSeparator());
                }
            }
        }

        private void BeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
