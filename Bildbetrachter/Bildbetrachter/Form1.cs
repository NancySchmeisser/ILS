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
                    pictureBox1.Load(textBox1.Text);
                else
                    MessageBox.Show("Die Datei existiert nicht!", "Fehler");
                }
        }
    }
}
