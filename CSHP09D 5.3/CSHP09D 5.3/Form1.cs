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

        void Check(int zahl)
        {
            if (zahl > 10)
                throw new Exception("Die Zahl ist zu groß.");
            if (zahl < 5)
                throw new Exception("Die Zahl ist zu klein");
        }

        private void button_Click(object sender, EventArgs e)
        {
            int zahl1;

            try
            {
                zahl1 = Convert.ToInt32(textBox1.Text);
                    try
                {
                    Check(zahl1);
                    MessageBox.Show("Ihre Eingabe war " + zahl1, "Meldung");
                }

                catch (Exception fehler)
                {
                    MessageBox.Show(fehler.Message, "Oh nein");
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Bei der Konvertierung ist etwas schief gelaufen.", "Oh nein");
            }
        }

        
    }
}
