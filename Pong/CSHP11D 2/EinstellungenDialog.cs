using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pong
{
    

    public partial class EinstellungenDialog : Form
    {
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

        //markiert den Button mit der aktuellen Einstellung der Größe des Spielfelds
        //Aufgabe 1 CSHP11D
        private void SetzeButton(int einstellung)
        {
            if (einstellung == 640)
                radioButton640.Checked = true;
            if (einstellung == 1024)
                radioButton1024.Checked = true;
            if (einstellung > 1024)
                radioButtonMaximal.Checked = true;
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
