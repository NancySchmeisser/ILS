using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bildbetrachter
{
    public partial class Bildbetrachter : Form
    {
        public Bildbetrachter()
        {
            InitializeComponent();
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAnzeigen_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                if (System.IO.File.Exists(textBox1.Text))
                {
                    if (checkBoxNeuesFenster.Checked == true)
                    {
                        FormMax neuesFormular = new FormMax();
                        neuesFormular.BildLaden(textBox1.Text);
                        neuesFormular.ShowDialog();
                    }
                    else
                    {
                        pictureBox1.Load(textBox1.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("Die Datei existiert nicht!", "Fehler");
            }
        }        

        // Was tut diese Methode?
        private void tabPageEinzel_Click(object sender, EventArgs e)
        {
          
        }

        private void checkBoxOptimaleGröße_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOptimaleGröße.Checked == true)
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;


        }

        private void buttonÖffnen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
            buttonAnzeigen_Click(sender, e);
        }

        private void OpenFileDialog_FileOk(object sender, EventArgs e)
        {
            pictureBox1.Load(openFileDialog1.FileName);
            buttonAnzeigen_Click(sender, e);
        }

        private void buttonAuswaehlen_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            string[] dateien = openFileDialog2.FileNames;
            foreach (string datei in dateien)
                listBox1.Items.Add(datei);

        }
    }                                                            
}
