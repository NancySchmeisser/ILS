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
      
      

        System.Drawing.Drawing2D.DashStyle[] linienstil =
        {
            System.Drawing.Drawing2D.DashStyle.Dash,
            System.Drawing.Drawing2D.DashStyle.DashDot,
            System.Drawing.Drawing2D.DashStyle.DashDotDot,
            System.Drawing.Drawing2D.DashStyle.Dot,
            System.Drawing.Drawing2D.DashStyle.Solid,

        };

        System.Drawing.Drawing2D.HatchStyle[] fuellstil =
        {
            System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal,
            System.Drawing.Drawing2D.HatchStyle.Cross,
            System.Drawing.Drawing2D.HatchStyle.DottedGrid,
            System.Drawing.Drawing2D.HatchStyle.ForwardDiagonal,
            System.Drawing.Drawing2D.HatchStyle.Sphere,
            System.Drawing.Drawing2D.HatchStyle.Vertical,
            System.Drawing.Drawing2D.HatchStyle.Wave,
            System.Drawing.Drawing2D.HatchStyle.ZigZag,

        };
       

        public EineSpielerei()
        {
            InitializeComponent();
        }

        private void EineSpielerei_Load(object sender, EventArgs e)
        {
            linienfarbe = Color.Black;
            hintergrundfarbe = Color.Black;
           
            zeichenflaeche = panel1.CreateGraphics();

            foreach (System.Drawing.Drawing2D.DashStyle element in linienstil)
                listBoxLinieStil.Items.Add("");

            foreach (System.Drawing.Drawing2D.HatchStyle element in fuellstil)
                listBoxHintergrundMuster.Items.Add("");
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
            Form form = Form.Linie;
            if (radioButtonKreis.Checked)
                form = Form.Kreis;
            if (radioButtonRechteck.Checked)
                form = Form.Rechteck;

            Animiere(form);
            return;

            int groesse = 0;
            Pen stift = new Pen(linienfarbe);
            SolidBrush pinsel = new SolidBrush(hintergrundfarbe);

            stift.Width = Convert.ToInt32(numericUpDownLinieStaerke.Value);

            if (listBoxLinieStil.SelectedIndex >= 0)
                stift.DashStyle = linienstil[listBoxLinieStil.SelectedIndex];


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

                if (radioButtonHintergrundMuster.Checked == true && listBoxHintergrundMuster.SelectedIndex >= 0)
                {
                    System.Drawing.Drawing2D.HatchBrush musterPinsel = new System.Drawing.Drawing2D.HatchBrush(fuellstil[listBoxHintergrundMuster.SelectedIndex], stift.Color, Color.White);
                    zeichenflaeche.FillEllipse(musterPinsel, panel1.ClientRectangle.Left + groesse, panel1.ClientRectangle.Top + groesse, panel1.ClientRectangle.Width - (groesse * 2), panel1.ClientRectangle.Height - (groesse * 2));

                }
                    
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

        private void listBoxLinieStil_DrawItem(object sender, DrawItemEventArgs e)
        {
            int y;

            Pen boxStift = new Pen(Color.Black);
            y = (e.Bounds.Top + e.Bounds.Bottom) / 2;
            e.DrawBackground();
            boxStift.DashStyle = linienstil[e.Index];
            e.Graphics.DrawLine(boxStift, e.Bounds.Left + 1, y, e.Bounds.Right - 1, y);
        }

        private void listBoxHintergrundMuster_DrawItem(object sender, DrawItemEventArgs e)
        {
            System.Drawing.Drawing2D.HatchBrush boxPinsel = new System.Drawing.Drawing2D.HatchBrush(fuellstil[e.Index], Color.Black, Color.White);
            e.DrawBackground();
            e.Graphics.FillRectangle(boxPinsel, e.Bounds.Left + 1, e.Bounds.Top + 1, e.Bounds.Width - 1, e.Bounds.Height - 1);
        }

        public enum Form
        {
            Linie,
            Kreis,
            Rechteck
        }

        private void Animiere(Form form)
        {
            Pen stift = new Pen(Color.Black);
            Rectangle bereich;
            bereich = new Rectangle(150, 150, 0, 0);

            var wiederholungen = Convert.ToInt32(numericUpDownWdh.Value);
            var geschwindigkeit = Convert.ToInt32(numericUpDownGeschw.Value) * 2;

            for (int wh = 0; wh < wiederholungen; wh++)
            {
                 for (int durchlauf = 0; durchlauf < 300 / geschwindigkeit ; durchlauf++)
                {
                    bereich.Width = bereich.Width + geschwindigkeit;
                    bereich.Height = bereich.Height + geschwindigkeit;
                    var graphics = panel1.CreateGraphics();
                    bereich.Location = new Point(bereich.Location.X - geschwindigkeit / 2, bereich.Location.Y - geschwindigkeit / 2);
                    switch(form)
                    {
                        case Form.Kreis:
                            graphics.DrawEllipse(stift, bereich);
                            break;
                        case Form.Rechteck:
                            graphics.DrawRectangle(stift, bereich);
                            break;
                        case Form.Linie:
                            graphics.DrawLine(stift, new Point(150, bereich.Y), new Point(150, bereich.Y + bereich.Height));
                            break;
                        default:
                            break;
                    }
                    System.Threading.Thread.Sleep(20);
                    graphics.Clear(BackColor);
                }

                for (int durchlauf = 0; durchlauf < 300 / geschwindigkeit; durchlauf++)
                {
                    bereich.Width = bereich.Width - geschwindigkeit;
                    bereich.Height = bereich.Height - geschwindigkeit;
                    var graphics = panel1.CreateGraphics();
                    bereich.Location = new Point(bereich.Location.X + geschwindigkeit/2, bereich.Location.Y + geschwindigkeit / 2);
                    switch (form)
                    {
                        case Form.Kreis:
                            graphics.DrawEllipse(stift, bereich);
                            break;
                        case Form.Rechteck:
                            graphics.DrawRectangle(stift, bereich);
                            break;
                        case Form.Linie:
                            graphics.DrawLine(stift, new Point(150, bereich.Y), new Point(150, bereich.Y + bereich.Height));
                            break;
                        default:
                            break;
                    }
                    System.Threading.Thread.Sleep(20);
                    graphics.Clear(BackColor);
                }
            }
        }
    }
}
