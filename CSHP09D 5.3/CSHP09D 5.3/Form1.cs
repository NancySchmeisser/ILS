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



        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                int[] test = new int[100000000];
                test[0] = 10;
            }

            catch (Exception fehler)
            {
                MessageBox.Show(fehler.Message, "Oh nein");
            }

            finally
            {
                MessageBox.Show("Diese Meldung erscheint immer");
            }

        }
    }
}
