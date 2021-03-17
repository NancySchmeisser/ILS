using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaschenrechnerFehler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonBerechnen_Click(object sender, EventArgs e)
        {
            float zahl1, zahl2, ergebnis = 0;
            bool divDurchNull = false;
            //die beiden Zahlen einlesen und konvertieren
            zahl1 = Convert.ToSingle(textBoxZahl1.Text); 
            zahl2 = Convert.ToSingle(textBoxZahl2.Text);
            //die Rechenoperation ermitteln und ausführen
            if (radioButtonAddition.Checked == true)
                ergebnis = zahl1 + zahl2;
            if (radioButtonSubtraktion.Checked == true)
                ergebnis = zahl1 - zahl2;
            if (radioButtonMultiplikation.Checked == true)
                ergebnis = zahl1 * zahl2;
            if (radioButtonDivision.Checked == true)
            {
                //wird eine Division durch Null versucht?
                if (zahl2 == 0)
                    divDurchNull = true;
                else
                    ergebnis = zahl1 / zahl2;
            }
            //wurde durch Null dividiert?
            if (divDurchNull == true)
                labelAnzeige.Text = "Nicht definiert!";
            else
                labelAnzeige.Text = Convert.ToString(ergebnis);
        }

        private void ButtonBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
