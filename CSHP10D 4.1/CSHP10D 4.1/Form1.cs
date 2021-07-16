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

        public EineSpielerei()
        {
            InitializeComponent();
        }

        private void EineSpielerei_Load(object sender, EventArgs e)
        {
            linienfarbe = Color.Black;
           
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
            Pen stift = new Pen(Color.Black);
            SolidBrush pinsel = new SolidBrush(Color.Black);

            switch (comboBoxLinieFarbe.SelectedIndex)
            {
                case 0:
                    stift.Color = Color.Black;
                    break;
                case 1:
                    stift.Color = Color.Red;
                    break;
                case 2:
                    stift.Color = Color.Blue;
                    break;
                case 3:
                    stift.Color = Color.Green;
                    break;
            }

            switch (comboBoxHintergrundFarbe.SelectedIndex)
            {
                case 0:
                    pinsel.Color = Color.Black;
                    break;
                case 1:
                    pinsel.Color = Color.Red;
                    break;
                case 2:
                    pinsel.Color = Color.Blue;
                    break;
                case 3:
                    pinsel.Color = Color.Green;
                    break;
            }

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
    }
}
