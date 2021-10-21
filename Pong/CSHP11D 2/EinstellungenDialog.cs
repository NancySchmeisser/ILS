namespace Pong
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class EinstellungenDialog : Form
    {
        //Felder für die Farben
        //Aufgabe 2 CSHP11D
        public Color rahmenFarbe;
        public Color spielfeldFarbe;

        public EinstellungenDialog()
        {
            InitializeComponent();
        }

        public Point LiefereWert()
        {
            Point rueckgabe = new Point(0, 0);
            if (radioButton320.Checked == true)
                rueckgabe = new Point(320, 200);
            if (radioButton640.Checked == true)
                rueckgabe = new Point(640, 480);
            if (radioButton1024.Checked == true)
                rueckgabe = new Point(1024, 768);
            if (radioButtonMaximal.Checked == true)
                rueckgabe = new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            return rueckgabe;
        }

        //setzt den jeweiligen Button auf die aktuelle Einstellung der Spielfeldgröße
        //Aufgabe 1 CSHP11D
        public void SetzeButton(int aktuelleGröße)
        {

            if (aktuelleGröße == 320)
                radioButton320.Checked = true;
            else if (aktuelleGröße == 640)
                radioButton640.Checked = true;
            else if (aktuelleGröße == 1024)
                radioButton1024.Checked = true;
            else
                radioButtonMaximal.Checked = true;
        }

        //Aufgabe 2 CSHP11D
        private void buttonRahmenfarbe_Click(object sender, EventArgs e)
        {
            if (colorDialogRahmen.ShowDialog() == DialogResult.OK)
            {
                rahmenFarbe = colorDialogRahmen.Color;
            }
        }
        //Aufgabe 2 CSHP11D
        private void buttonSpielfeldfarbe_Click(object sender, EventArgs e)
        {
            if (colorDialogRahmen.ShowDialog() == DialogResult.OK)
            {
                spielfeldFarbe = colorDialogRahmen.Color;
                Vorschau.Refresh();
            }
        }
        //Aufgabe 2 CSHP11D
        private void Vorschau_Paint(object sender, PaintEventArgs e)
        {
            Graphics vorschau = Vorschau.CreateGraphics();
            Pen stift = new Pen(rahmenFarbe);
            SolidBrush pinsel = new SolidBrush(spielfeldFarbe);

            //Zeichne die Hintergrundfarbe
            vorschau.FillRectangle(pinsel, 0, 0, Vorschau.Width, Vorschau.Height);

            //Zeichne den Rahmen, Schläger und Bal
            vorschau.DrawRectangle(stift, 0, 0, Vorschau.Width, Vorschau.Height);
            vorschau.DrawRectangle(stift, 15, 50, 1, 25);

            pinsel.Color = rahmenFarbe;
            vorschau.FillRectangle(pinsel, 100, 50, 10, 10);

        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
