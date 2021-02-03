using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHP07D_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKopieren_Click(object sender, EventArgs e)
        {
            string tempKette;
            //den Text aus dem Ziel in Sicherheit bringen
            tempKette = labelZiel.Text;
            //den Text aus der Quelle in das Ziel kopieren
            labelZiel.Text = labelQuelle.Text;
            //den gesicherten Text in die Quelle kopieren
            labelQuelle.Text = tempKette;
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            labelQuelle.Text = comboBox1.SelectedItem.ToString();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelZiel.Text = listBox1.SelectedItem.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                listBox1.Visible = true;
                comboBox1.Visible = true;
            }
            else
            {
                listBox1.Visible = false;
                comboBox1.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;

            labelZiel.Text = "Ziel";
            labelQuelle.Text = "Quelle";
        }
    }
}
