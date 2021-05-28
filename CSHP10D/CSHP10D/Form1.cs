using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHP10D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Schließen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //einen schwarzen Stift erzeugen
            Pen stift = new Pen(Color.Black);
            //eine Variable vom Typ Rectangle
            Rectangle bereich;
            //den Client-Bereich beschaffen
            bereich = ClientRectangle;
            //in einer Schleife anpassen
            for (int durchlauf = 0; durchlauf < 22; durchlauf++)
            {
                bereich.Width = bereich.Width - 10;
                bereich.Height = bereich.Height - 10;
                bereich.Location = new Point(bereich.Location.X + 5, bereich.Location.Y + 5);
                //ein Rechteck zeichnen
                e.Graphics.DrawRectangle(stift, bereich);
                //einen Moment warten
                System.Threading.Thread.Sleep(100);
                //den Zeichenbereich löschen
                e.Graphics.Clear(BackColor);

                
            }
        }
    }
}
