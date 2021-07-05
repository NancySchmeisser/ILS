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
            zeichenfläche.Clear(BackColor);
            try
            {
                Bitmap bild = (Bitmap)(Image.FromFile("c:\\beispiele\\smiley.bmp"));
                TextureBrush grafikPinsel = new TextureBrush(bild);
                grafikPinsel.WrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
                zeichenfläche.FillRectangle(grafikPinsel, 10, 10, 240, 240);
            }
            catch(System.IO.FileNotFoundException)
            {
                MessageBox.Show("Die Datei ist nicht vorhanden");
            }
            

        }

        private void buttonFüllen_Click(object sender, EventArgs e)
        {

        }

        private void buttonVerlauf_Click(object sender, EventArgs e)
        {

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
