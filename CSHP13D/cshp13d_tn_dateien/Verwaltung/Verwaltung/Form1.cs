using System;
using System.IO;
using System.Windows.Forms;

namespace Verwaltung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //eine Warmeldung zeigen
            MessageBox.Show("Das Programm arbeitet fest auf den Order C:\\test\n" +
            "und verfügt über keinerlei Sicherheitsabfragen. Arbeiten Sie\n" +
            " daher nur mit Dateien, die Sie nicht mehr benötigen.", "Achtung!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //die Werte für das Laufwerk C: beschaffen
            DriveInfo laufwerk = new DriveInfo("c");
            labelLW.Text = laufwerk.Name;
            //den aktuellen Ordner auf c:\test setzen
            Directory.SetCurrentDirectory("c:\\test");
        }

        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            DriveInfo laufwerk = new DriveInfo(labelLW.Text);
            MessageBox.Show("Freier Platz: " + laufwerk.AvailableFreeSpace + "\n" + "Gesamtkapazität: " + laufwerk.TotalSize);
        }

        private void ButtonLesen_Click(object sender, EventArgs e)
        {
            //die Dateien im Ordner c:\test einlesen
            string[] dateinamen = Directory.GetFiles("c:\\test");
            //das Listenfeld leeren
            listBox1.Items.Clear();
            //in das Listenfeld schreiben, aber nur den eigentlichen Namen
            foreach (string datei in dateinamen)
                listBox1.Items.Add(Path.GetFileName(datei));
        }

        private void ButtonLoeschen_Click(object sender, EventArgs e)
        {
            //ist eine Datei ausgewählt?
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Bitte wählen Sie erst eine Datei aus.");
            else
            {
                //die Datei löschen
                File.Delete(Convert.ToString(listBox1.SelectedItem));
                //die Anzeige über die Methode ButtonLesen_Click() aktualisieren
                ButtonLesen_Click(this, EventArgs.Empty);
            }
        }

        private void ButtonBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
