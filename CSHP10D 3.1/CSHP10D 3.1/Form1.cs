using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHP10D_3._1
{
    public partial class Form1 : Form
    {
        Graphics zeichenfläche;

        Pen stift;
        SolidBrush pinsel;

        Pen stiftKopie;
        Brush pinselKopie;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zeichenfläche = CreateGraphics();

            stift = new Pen(Color.Black);
            pinsel = new SolidBrush(Color.Blue);

            stiftKopie = (Pen)(stift.Clone());
            pinselKopie = (SolidBrush)(pinsel.Clone());
        }

        private void buttonEasy_Click(object sender, EventArgs e)
        {
            zeichenfläche.Clear(BackColor);
            stift.Color = Color.Red;
            zeichenfläche.DrawRectangle(stift, 10, 10, 100, 100);
            stift.Color = Color.Green;
            stift.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            stift.Width = 3;
            zeichenfläche.DrawLine(stift, 0, 120, 100, 120);
            stift.Color = Color.Blue;
            stift.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            zeichenfläche.DrawLine(stift, 0, 140, 100, 140);
            stift.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            stift.Width = 10;
            zeichenfläche.DrawLine(stift, 0, 160, 100, 160);
            pinsel.Color = Color.Red;
            zeichenfläche.FillRectangle(pinsel, 150, 10, 90, 90);
            System.Drawing.Drawing2D.HatchBrush musterPinsel = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Cross, Color.Blue, Color.Green);
            zeichenfläche.FillRectangle(musterPinsel, 150, 110, 90, 90);


        }

        private void buttonTexte_Click(object sender, EventArgs e)
        {
            Rectangle bereich;
            zeichenfläche.Clear(BackColor);
            Font schrift = new Font("Arial", 12);
            bereich = ClientRectangle;
            bereich.Width = 100;
            bereich.Height = 200;
            bereich.Location = new Point(100, 100);
            zeichenfläche.DrawString("Ich stehe in einem Rechteck", schrift, pinsel, bereich);

        }

        private void buttonFüllen_Click(object sender, EventArgs e)
        {

        }

        private void buttonVerlauf_Click(object sender, EventArgs e)
        {
            zeichenfläche.Clear(BackColor);
            System.Drawing.Drawing2D.LinearGradientBrush verlaufPinsel = new System.Drawing.Drawing2D.LinearGradientBrush(new Point(10, 10), new Point(300, 300), Color.Red, Color.Blue);
            zeichenfläche.FillRectangle(verlaufPinsel, 10, 10, 50, 50);
            zeichenfläche.FillEllipse(verlaufPinsel, 10, 60, 50, 50);
            zeichenfläche.FillRectangle(verlaufPinsel, 70, 10, 200, 200);
            stift.Brush = verlaufPinsel;
            stift.Width = 10;
            zeichenfläche.DrawLine(stift, 10, 250, 270, 250);
        }


        private void buttonEnden_Click(object sender, EventArgs e)
        {
            zeichenfläche.Clear(BackColor);
            stift.Color = Color.Red;
            stift.StartCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
            stift.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            stift.Width = 5;
            zeichenfläche.DrawLine(stift, 10, 120, 100, 120);
            stift.Color = Color.Blue;
            stift.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            stift.StartCap = System.Drawing.Drawing2D.LineCap.SquareAnchor;
            stift.EndCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            zeichenfläche.DrawLine(stift, 10, 140, 100, 140);

        }
    }
}
