namespace CSHP11D_2
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        internal struct Spielball
        {
            public bool richtungX;

            public bool richtungY;

            public int winkel;
        }

        internal Graphics zeichenflaeche;

        internal Rectangle spielfeldGroesse;

        internal int spielfeldMaxX, spielfeldMaxY, spielfeldMinX, spielfeldMinY;

        internal int spielfeldLinienbreite;

        internal int schlaegerGroesse;

        internal Spielball ballPosition;

        internal SolidBrush pinsel;

        public Form1()
        {
            InitializeComponent();
            //die Breite der Linien
            spielfeldLinienbreite = 10;
            //die Größe des Schlägers
            schlaegerGroesse = 50;
            //erst einmal geht der Ball nach rechts und oben mit
            //dem Winkel 0
            ballPosition.richtungX = true;
            ballPosition.richtungX = true;
            ballPosition.winkel = 0;
            //den Pinsel erzeugen
            pinsel = new SolidBrush(Color.Black);
            //die Zeichenfläche beschaffen
            zeichenflaeche = spielfeld.CreateGraphics();
            //das Spielfeld bekommt einen schwarzen Hintergurnd
            spielfeld.BackColor = Color.Black;

            SetzeSpielfeld();
            NeuerBall();
        }

        internal void SetzeSpielfeld()
        {
            spielfeldGroesse = spielfeld.ClientRectangle;
            //die minimalen und die maximalen Ränder festlegen
            //dabei werden die Linien berücksichtigt
            spielfeldMaxX = spielfeldGroesse.Right - spielfeldLinienbreite;

            //den linken Rand verschieben wir ein Pixel nach rechts
            spielfeldMinX = spielfeldGroesse.Left + spielfeldLinienbreite + 1;
            spielfeldMaxY = spielfeldGroesse.Bottom - spielfeldLinienbreite;
            spielfeldMinY = spielfeldGroesse.Top + spielfeldLinienbreite;
        }

        internal void ZeichneSpielfeld()
        {
            //die weißen Begrenzungen
            pinsel.Color = Color.White;
            //ein Rechteck oben
            zeichenflaeche.FillRectangle(pinsel, 0, 0, spielfeldMaxX, spielfeldLinienbreite);
            //ein Rechteck rechts
            zeichenflaeche.FillRectangle(pinsel, spielfeldMaxX, 0, spielfeldLinienbreite, spielfeldMaxY + spielfeldLinienbreite);
            //ein Rechteck unten
            zeichenflaeche.FillRectangle(pinsel, 0, spielfeldMaxY, spielfeldMaxX, spielfeldLinienbreite);
            //Graue Linie Mitte
            pinsel.Color = Color.Gray;
            zeichenflaeche.FillRectangle(pinsel, spielfeldMaxX / 2, spielfeldMinY, spielfeldLinienbreite, spielfeldMaxY - spielfeldLinienbreite);
        }

        internal void ZeichneBall(Point position)
        {
            ball.Location = position;
        }

        private void spielfeld_Paint(object sender, PaintEventArgs e)
        {
            ZeichneSpielfeld();
        }

        private void schlaeger_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                ZeichneSchlaeger(e.Y + schlaeger.Top);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int neuX = 0, neuY = 0;
            //abhängig von der Bewegungsrichtung die
            //Koordinaten neu setzen
            if (ballPosition.richtungX == true)
                neuX = ball.Left + 10;
            else
                neuX = ball.Left - 10;
            if (ballPosition.richtungY == true)
                neuY = ball.Top - ballPosition.winkel;
            else
                neuY = ball.Top + ballPosition.winkel;
            //den Ball neu zeichnen
            ZeichneBall(new Point(neuX, neuY));


        }

        internal void ZeichneSchlaeger(int y)
        {
            //befindet sich der Schläger im Spielfeld?
            if(((y + schlaegerGroesse) < spielfeldMaxY) && (y > spielfeldMinY))
            schlaeger.Top = y;
        }

        //setzt die Einstellungen für einen neuen Ball und einen neuen Schläger

        void NeuerBall()
        {
            //die Größe des Balls setzen
            ball.Width = 10;
            ball.Height = 10;
            //die Größe des Schlägers setzen
            schlaeger.Width = spielfeldLinienbreite;
            schlaeger.Height = schlaegerGroesse;
            //beide Panels werden weiß
            ball.BackColor = Color.White;
            schlaeger.BackColor = Color.White;
            //den Schläger positionieren
            //links an den Rand
            schlaeger.Left = 2;
            //ungefähr in die Mitte
            ZeichneSchlaeger((spielfeldMaxY / 2) - (schlaegerGroesse / 2));
            //der Ball kommt vor den Schläger ungefähr in die Mitte
            ZeichneBall(new Point(spielfeldMinX, spielfeldMaxY / 2));

        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
