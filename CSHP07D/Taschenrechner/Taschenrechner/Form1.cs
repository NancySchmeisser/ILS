using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Taschenrechner : Form
    {
        public Taschenrechner()
        {
            InitializeComponent();
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBerechnen_Click(object sender, EventArgs e)
        {

          

            float zahl1, zahl2, ergebnis = 0;
            bool divDurchNull = false;

            try
            {
                zahl1 = Convert.ToSingle(textBoxZahl1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ihre Eingabe " + textBoxZahl1.Text + " war nicht gültig. ", "Fehler");
                return;
            }

            zahl2 = Convert.ToSingle(textBoxZahl2.Text);



            if (ComboBoxAuswahl.SelectedIndex == 0)
                ergebnis = zahl1 + zahl2;
            if (ComboBoxAuswahl.SelectedIndex == 1)
                ergebnis = zahl1 - zahl2;
            if (ComboBoxAuswahl.SelectedIndex == 2)
                ergebnis = zahl1 * zahl2;
            if (ComboBoxAuswahl.SelectedIndex == 3)
            {
                if (zahl2 == 0)
                    divDurchNull = true;
                else
                    ergebnis = zahl1 / zahl2;
            }

            if (divDurchNull == true)
                labelAnzeige.Text = "Nicht definiert!";
            else
                labelAnzeige.Text = Convert.ToString(ergebnis);


        }

        private void Taschenrechner_Load(object sender, EventArgs e)
        {
            ComboBoxAuswahl.SelectedIndex = 0;
        }
    }
}
