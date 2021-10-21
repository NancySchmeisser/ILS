namespace Pong
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class EinstellungenDialog : Form
    {
        public Color rahmenfarbe;
        public Color spielfeldfarbe;
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

        private void buttonRahmenfarbe_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                rahmenfarbe = colorDialog1.Color;
            }
        }

        private void buttonSpielfeldfarbe_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                spielfeldfarbe = colorDialog1.Color;
            }
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
