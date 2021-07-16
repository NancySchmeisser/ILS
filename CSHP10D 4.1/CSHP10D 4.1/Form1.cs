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
        private Color linienfarbe;
        private Color hintergrundfarbe;

        public EineSpielerei()
        {
            InitializeComponent();
        }

        private void EineSpielerei_Load(object sender, EventArgs e)
        {
            linienfarbe = Color.Black;
            hintergrundfarbe = Color.Black;
           
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

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int groesse = 0;
            Pen stift = new Pen(linienfarbe);
            SolidBrush pinsel = new SolidBrush(linienfarbe);

            stift.Width = Convert.ToInt32(numericUpDownLinieStaerke.Value);

            switch (trackBar1.Value)
            {
                case 1:
                    groesse = 125;
                    break;
                case 2:
                    groesse = 100;
                    break;
                case 3:
                    groesse = 75;
                    break;
            }

            if (radioButtonKreis.Checked == true)
            {
                if (radioButtonHintergrundOhne.Checked == true)
                    zeichenflaeche.DrawEllipse(stift, panel1.ClientRectangle.Left + groesse, panel1.ClientRectangle.Top + groesse, panel1.ClientRectangle.Width - (groesse * 2), panel1.ClientRectangle.Height - (groesse * 2));
                if (radioButtonHintergrundFarbe.Checked == true)
                    zeichenflaeche.FillEllipse(pinsel, panel1.ClientRectangle.Left + groesse, panel1.ClientRectangle.Top + groesse, panel1.ClientRectangle.Width - (groesse * 2), panel1.ClientRectangle.Height - (groesse * 2));

            }

            if (radioButtonRechteck.Checked == true)
            {
                if (radioButtonHintergrundOhne.Checked == true)
                    zeichenflaeche.DrawRectangle(stift, panel1.ClientRectangle.Left + groesse, panel1.ClientRectangle.Top + groesse, panel1.ClientRectangle.Width - (groesse * 2), panel1.ClientRectangle.Height - (groesse * 2));
                if (radioButtonHintergrundFarbe.Checked == true)
                    zeichenflaeche.FillRectangle(pinsel, panel1.ClientRectangle.Left + groesse, panel1.ClientRectangle.Top + groesse, panel1.ClientRectangle.Width - (groesse * 2), panel1.ClientRectangle.Height - (groesse * 2));

            }

            if (radioButtonLinie.Checked == true)
            {
                zeichenflaeche.DrawLine(stift, panel1.ClientRectangle.Left + groesse, panel1.ClientRectangle.Height / 2, panel1.ClientRectangle.Width - groesse, panel1.ClientRectangle.Height / 2);
            }
        }

        private void buttonLinieFarbe_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panelLinieFarbeVorschau.BackColor = colorDialog1.Color;
                linienfarbe = colorDialog1.Color;
            }
        }

        private void buttonHintergrundFarbe_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panelHintergrundFarbeVorschau.BackColor = colorDialog1.Color;
                hintergrundfarbe = colorDialog1.Color;
                radioButtonHintergrundFarbe.Checked = true;
            }
        }
    }
}
