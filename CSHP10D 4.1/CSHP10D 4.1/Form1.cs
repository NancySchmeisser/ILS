using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHP10D_4._1
{
    public partial class EineSpielerei : Form
    {
        private Graphics zeichenflaeche;

        public EineSpielerei()
        {
            InitializeComponent();
        }

        private void EineSpielerei_Load(object sender, EventArgs e)
        {
            comboBoxHintergrundFarbe.SelectedIndex = 0;
            comboBoxLinieFarbe.SelectedIndex = 0;

            zeichenflaeche = panel1.CreateGraphics();
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            zeichenflaeche.Clear(panel1.BackColor);
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
