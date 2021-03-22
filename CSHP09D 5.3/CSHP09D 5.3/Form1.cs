using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHP09D_5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ergebnis, zahl2, zahl1 = 10;

            try
            {
                zahl2 = Convert.ToInt32(textBox1.Text);
                try
                {
                    ergebnis = zahl1 / zahl2;
                    MessageBox.Show("Das Ergebnis ist " + ergebnis, "Hurra");
                }

                catch (DivideByZeroException)
                {
                    MessageBox.Show("Eine Division durch Null ist nicht defíniert", "Oh nein");
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Ein anderes Problem", "Oh nein");

            }
        }

        
    }
}
