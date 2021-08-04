using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHP10D_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DrawLine(object sender, EventArgs e)
        {
            Graphics zeichenfläche;
            Pen stift;

            zeichenfläche = CreateGraphics();
            stift = new Pen(Color.Black);

            int xMax = ClientRectangle.Right - 1;
            int yMax = ClientRectangle.Bottom - 1;

            int xPos = 0, yPos = 0;

            while (yPos < yMax)
            {
                zeichenfläche.DrawLine(stift, 0, yPos, xMax, yPos);
                yPos = yPos + 10;
            }

            Brush pinsel = new SolidBrush(Color.Blue);

            while (xPos < xMax)
            {
                zeichenfläche.DrawLine(stift, xPos, 0, xPos, yMax);
                xPos = xPos + 10;
            }

            xPos = (ClientSize.Width / 2) - 50;
            yPos = (ClientSize.Height / 2) - 50;
            zeichenfläche.FillRectangle(pinsel, xPos, yPos, 100, 100);

            zeichenfläche.DrawLine(stift, 0, 0, xMax, yMax);
            zeichenfläche.DrawLine(stift, 0, yMax, xMax, 0);
        }

        private void buttonKreis_Click(object sender, EventArgs e)
        {
            Graphics zeichenfläche;
            Pen stift;

            zeichenfläche = CreateGraphics();
            stift = new Pen(Color.Black);

            zeichenfläche.DrawEllipse(stift, 100, 100, 100, 100);
        }
    }
}
