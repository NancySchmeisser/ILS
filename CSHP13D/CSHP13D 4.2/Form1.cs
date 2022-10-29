using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHP13D_4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSuche_Click(object sender, EventArgs e)
        {
            string dateiname;
            int treffer = 0;
            int punkte = 0;
            int neuePosition = 0;
            string name;
            //die Liste leeren
            listBox1.Items.Clear();
            //ist das Suchkriterium leer?
            if (textBox1.Text == string.Empty)
            {

            }
        }
    }
}
