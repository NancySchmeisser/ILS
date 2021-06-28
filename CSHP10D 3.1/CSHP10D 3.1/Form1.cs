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

        }

        private void buttonTexte_Click(object sender, EventArgs e)
        {

        }

        private void buttonFüllen_Click(object sender, EventArgs e)
        {

        }

        private void buttonVerlauf_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
