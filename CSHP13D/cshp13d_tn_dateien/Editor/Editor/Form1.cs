using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ÖffnenToolStripButton_Click(object sender, EventArgs e)
        {
            //den Öffnendialog anzeigen
            openFileDialog1.ShowDialog();
        }

        private void SpeichernToolStripButton_Click(object sender, EventArgs e)
        {
            //den Speichern unter-Dialog anzeigen
            saveFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //den Dateinamen beschaffen und die Datei dann laden
            string dateiname;
            dateiname = openFileDialog1.FileName;
            richTextBox1.LoadFile(dateiname, RichTextBoxStreamType.PlainText);
        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //den Dateinamen beschaffen und die Datei dann speichern
            string dateiname;
            dateiname = saveFileDialog1.FileName;
            richTextBox1.SaveFile(dateiname, RichTextBoxStreamType.PlainText);
        }
    }
}
