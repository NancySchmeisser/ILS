using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHP11D_2
{
    public partial class Form1 : Form
    {
        //die Felder
        //eine Struktur für die Richtung des Balls

        struct Spielball
        {
            //wenn die Richtung true ist, geht es nach oben
            //bzw nach rechts
            //sonst nach unten bzw. nach links
            public bool richtungX;
            public bool richtungY;
            //für die Veränderung des Bewegungswinkels
            public int winkel;
        }

        //für die Zeichenfläche
        Graphics zeichenfläche;
        //für das Spielfeld
        Rectangle spielfeldGroesse;
        int spielfeldMaxX, spielfeldMaxY, spielfeldMinX, spielfeldMinY;
        int spielfeldLininenbreite;
        //für den Schläger

        int schlaegerGroesse;
        //für den Ball
        Spielball ballPosition;
        //zum Zeichnen
        SolidBrush pinsel;

        public Form1()
        {
            InitializeComponent();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
