using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHP13D_1._2
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
            OpenFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //den Dateinamen beschaffen und die Datei dann laden
            string dateiname;
            dateiname = OpenFileDialog1.FileName;
            richTextBox1.LoadFile(dateiname, RichTextBoxStreamType.PlainText);
        }

        private void SpeichernToolStripButton_Click(object sender, EventArgs e)
        {
            //den Speichern unter-Dialog anzeigen
            saveFileDialog1.ShowDialog();
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
