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
                throw new Exception("Test");
            }

            catch (Exception fehler) when (fehler.Message == "Test")
            {
                MessageBox.Show("Gefiltert", "oh nein");
            }

            catch (Exception fehler)
            {
                MessageBox.Show("Ungefiltert" + fehler.Message, "oh nein");

            }

        }
    }
}
