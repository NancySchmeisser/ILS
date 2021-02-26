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

        private FormMax fensterBilderschau;

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
            if (listBox1.Items.Count != 0)
                listBox1.Items.Clear();
            foreach (string datei in dateien)
                listBox1.Items.Add(datei);                               

        }

        private void buttonStarten_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Sie müssen erst Dateien auswählen!", "Fehler");
                return;
            }

            if (listBox1.SelectedIndex == -1)
            {
                listBox1.SelectedIndex = 0;
                fensterBilderschau = new FormMax();
                fensterBilderschau.BildLaden(listBox1.SelectedItem.ToString());
                fensterBilderschau.Text = "Bilderschau";
                fensterBilderschau.ControlBox = false;
                fensterBilderschau.Show();
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
            {
                listBox1.SelectedIndex++;
                fensterBilderschau.BildLaden(listBox1.SelectedItem.ToString());
            }

            else
            {
                listBox1.SelectedIndex = -1;
                timer1.Stop();
                fensterBilderschau.Close();
            }
        }

        
        private void tabPageEinzel_Enter(object sender, EventArgs e)
        {
            AcceptButton = buttonAnzeigen;
        }

        private void TabPageSchau_Enter(object sender, EventArgs e)
        {
            AcceptButton = buttonStarten;
        }

    }                       
}
