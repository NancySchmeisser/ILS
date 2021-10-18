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

        internal bool spielPause;

        internal int aktuelleSpielzeit;

        internal Font schrift;

        internal Score spielpunkte = new Score();

        internal int punkteMehr, punkteWeniger;

        internal int winkelZufall;

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
            schrift = new Font("Arial", 12, FontStyle.Bold);
            //die Standardwerte setzen
            punkteMehr = 1;
            punkteWeniger = -5;
            winkelZufall = 5;



            SetzeSpielfeld();
            NeuerBall();
            //erst einmal ist das Spiel angehalten
            spielPause = true;
            //die Spielzeit in Sekunden setzen
            //  aktuelleSpielzeit = timerSpiel.Interval / 1000;
            //alle drei Timer sind zunächst angehalten
            timerBall.Enabled = false;
            timerSpiel.Enabled = false;
            timerSekunde.Enabled = false;
            pauseToolStripMenuItem.Enabled = false;
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
            //für die Zufallszahl
            Random zufall = new Random();

            ball.Location = position;
            //wenn der Ball rechts anstößt, änern wir die Richtung
            if ((position.X + 10) >= spielfeldMaxX)
                ballPosition.richtungX = false;
            //stößt er unten bzw. oben an, ebenfalls
            if ((position.Y + 10) >= spielfeldMaxY)
                ballPosition.richtungY = true;
            else
                if (position.Y <= spielfeldMinY)
                ballPosition.richtungY = false;

            //ist er wieder links, prüfen wir, ob der Schläger in
            //der Nähe ist
            if ((position.X == spielfeldMinX) && ((schlaeger.Top <= position.Y) && (schlaeger.Bottom >= position.Y)))
            {
                if (ballPosition.richtungX == false)
                    //einen Punkt dazu und die Punkte ausgeben
                    ZeichnePunkte(Convert.ToString(spielpunkte.VeraenderePunkte(punkteMehr)));
                //die Richtung ändern
                ballPosition.richtungX = true;
                //und den Winkel
                ballPosition.winkel = zufall.Next(winkelZufall);
            }

            //ist der Ball hinter dem Schläger?
            if (position.X < spielfeldMinX)
            {
                //fünf Punkte abziehen und die Punkte ausgeben
                ZeichnePunkte(Convert.ToString(spielpunkte.VeraenderePunkte(punkteWeniger)));

                //eine kurze Pause einlegen
                System.Threading.Thread.Sleep(1000);
                //und alles von vorne
                ZeichneBall(new Point(spielfeldMinX, position.Y));
                ballPosition.richtungX = true;
            }
        }

        private void spielfeld_Paint(object sender, PaintEventArgs e)
        {
            ZeichneSpielfeld();
            ZeichneZeit(Convert.ToString(aktuelleSpielzeit));
        }

        private void schlaeger_MouseMove(object sender, MouseEventArgs e)
        {
            if (spielPause == true)
                return;
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
            if (((y + schlaegerGroesse) < spielfeldMaxY) && (y > spielfeldMinY))
                schlaeger.Top = y;
        }

        private void timerSekunde_Tick(object sender, EventArgs e)
        {
            //eine Sekunde abziehen
            aktuelleSpielzeit = aktuelleSpielzeit - 1;
            //die Restzeit ausgeben
            ZeichneZeit(Convert.ToString(aktuelleSpielzeit));
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //erst einmal prüfen wir den Status
            //läuft das Spiel?
            if (spielPause == false)
            {
                //alle Timer anhalten
                timerBall.Enabled = false;
                timerSekunde.Enabled = false;
                timerSpiel.Enabled = false;
                //die Markierung im Menü einschalten
                pauseToolStripMenuItem.Checked = true;
                //den Text in der Titelleiste ändern
                this.Text = "Pong - Das Spiel ist angehalten!";
                spielPause = true;
            }
            else
            {
                //das Intervall für die verbelibende Spielzeit setzen
                timerSpiel.Interval = aktuelleSpielzeit * 1000;
                //alle Timer wieder an
                timerBall.Enabled = true;
                timerSekunde.Enabled = true;
                timerSpiel.Enabled = true;
                //die Markierung im Menü abschalten
                pauseToolStripMenuItem.Checked = false;
                //den Text in der Titelleiste änern
                this.Text = "Pong";
                spielPause = false;

            }
        }

        internal void NeuerBall()
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

        private void neuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //läuft ein Spiel
            //dann erst einmal pausieren
            if (spielPause == false)
            {
                pauseToolStripMenuItem_Click(sender, e);
                //den Dialog anzeigen
                NeuesSpiel();
                //und weiter spielem
                pauseToolStripMenuItem_Click(sender, e);
            }
            //wenn kein Spiel läuft, starten wir ein neues,
            //wenn im Dialog auf Ja geklickt wurde
            else
                if (NeuesSpiel() == true)
                pauseToolStripMenuItem_Click(sender, e);
        }

        private void BestenlisteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //zur Unterscheidung zwischen einem laufenden und 
            //einem nicht gestarteten Spiel
            bool weiter = false;
            //läuft ein Spiel? dann erst einmal pausieren
            if (spielPause == false)
            {
                pauseToolStripMenuItem_Click(sender, e);
                weiter = true;
            }
            //Ball und Schläger verstecken
            ball.Hide();
            schlaeger.Hide();
            //die Liste ausgeben
            spielpunkte.ListeAusgeben(zeichenflaeche, spielfeldGroesse);
            //fünf Sekunden warten
            System.Threading.Thread.Sleep(5000);
            //die Zeichenfläche löschen
            zeichenflaeche.Clear(spielfeld.BackColor);
            //Ball und Schläger wieder anzeigen
            ball.Show();
            schlaeger.Show();
            //das Spiel wieder fortsetzen, wenn wir es angehalten haben
            if (weiter == true)
                pauseToolStripMenuItem_Click(sender, e);
        }

        private void sehrEinfachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //das Intervall für den Ball setzen
            timerBall.Interval = 200;
            //die Einstellungen setzen
            SetzeEinstellungen(100, 1, -20, 2);
            //und die Markierungen
            schwerToolStripMenuItem.Checked = false;
            sehrEinfachToolStripMenuItem.Checked = true;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = false;
            sehrSchwerToolStripMenuItem.Checked = false;
        }

        private void einfachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //das Intervall für den Ball setzen
            timerBall.Interval = 100;
            //die Einstellungen setzen
            SetzeEinstellungen(50, 1, -5, 5);
            //und die Markierungen
            schwerToolStripMenuItem.Checked = false;
            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = true;
            mittelToolStripMenuItem.Checked = false;
            sehrSchwerToolStripMenuItem.Checked = false;
        }

        private void mittelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //das Intervall für den Ball setzen
            timerBall.Interval = 50;
            //die Einstellungen setzen
            SetzeEinstellungen(50, 3, -5, 15);
            //und die Markierungen
            schwerToolStripMenuItem.Checked = false;
            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = true;
            sehrSchwerToolStripMenuItem.Checked = false;
        }

        private void schwerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //das Intervall für den Ball setzen
            timerBall.Interval = 25;
            //die Einstellungen setzen
            SetzeEinstellungen(50, 10, -5, 25);
            //und die Markierungen
            schwerToolStripMenuItem.Checked = true;
            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = false;
            sehrSchwerToolStripMenuItem.Checked = false;
        }

        private void sehrSchwerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //das Intervall für den Ball setzen
            timerBall.Interval = 10;
            //die Einstellungen setzen
            SetzeEinstellungen(20, 20, -5, 40);
            //und die Markierungen
            schwerToolStripMenuItem.Checked = false;
            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = false;
            sehrSchwerToolStripMenuItem.Checked = true;
        }

        private void timerSpiel_Tick(object sender, EventArgs e)
        {
            //das Spiel anhalten
            pauseToolStripMenuItem_Click(sender, e);
            //eine Meldung anzeigen
            MessageBox.Show("Die Zeit ist um", "Spielende", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //nachsehen, ob ein neuer Eintrag in der Bestenliste
            //erfolgen kann
            if (spielpunkte.NeuerEintrag() == true)
            {
                //Ball und Schläger verstecken
                ball.Hide();
                schlaeger.Hide();
                //die Liste ausgeben
                spielpunkte.ListeAusgeben(zeichenflaeche, spielfeldGroesse);
                //fünf Sekunden warten
                System.Threading.Thread.Sleep(5000);
                //die Zeichenfläche löschen
                zeichenflaeche.Clear(spielfeld.BackColor);
                //Ball und Schläger wieder anzeigen
                ball.Show();
                schlaeger.Show();
            }
        }

        internal void ZeichneZeit(string restzeit)
        {


            //zuerst die alte Anzeige überschreiben
            pinsel.Color = spielfeld.BackColor;
            zeichenflaeche.FillRectangle(pinsel, spielfeldMaxX - 50, spielfeldMinY + 20, 30, 20);
            //in weißer Schrift
            pinsel.Color = Color.White;
            //die Auszeichnungen für die Schrift werden beim
            //Erstellen des Spielfelds gesetzt
            zeichenflaeche.DrawString(restzeit, schrift, pinsel, new Point(spielfeldMaxX - 50, spielfeldMinY + 20));
        }

        internal bool NeuesSpiel()
        {
            bool ergebnis = false;
            if (MessageBox.Show("Neues Spiel starten?", "Neues Spiel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //die Spielzeit neu setzen
                aktuelleSpielzeit = 120;
                spielpunkte.LoeschePunkte();
                ZeichnePunkte("0");
                //alles neu zeichnen
                ZeichneSpielfeld();
                NeuerBall();
                ZeichneZeit(Convert.ToString(aktuelleSpielzeit));
                ergebnis = true;
                pauseToolStripMenuItem.Enabled = true;
                //Einstellungen deaktivieren
                schwierigkeitsgradToolStripMenuItem.Enabled = false;
                spielfeldToolStripMenuItem.Enabled = false;
                ergebnis = true;
            }
            return ergebnis;
        }

        internal void SetzeEinstellungen(int schlaeger, int mehr, int weniger, int winkel)
        {
            schlaegerGroesse = schlaeger;
            punkteMehr = mehr;
            punkteWeniger = weniger;
            winkelZufall = winkel;
        }

        internal void ZeichnePunkte(string punkte)
        {
            //zuerst die alte Anzeige überschreiben
            pinsel.Color = spielfeld.BackColor;

            zeichenflaeche.FillRectangle(pinsel, spielfeldMaxX - 50, spielfeldMinY + 40, 30, 20);
            //in weißer Schrift
            pinsel.Color = Color.White;
            //die Einstellungen für die Schrift werden beim
            //Erstellen des Spielfelds gesetzt
            zeichenflaeche.DrawString(punkte, schrift, pinsel, new Point(spielfeldMaxX - 50, spielfeldMinY + 40));
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
