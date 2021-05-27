namespace TaschenrechnerFehler
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonBerechnen_Click(object sender, EventArgs e)
        {
            PruefenUndBerechnen(textBoxZahl1, textBoxZahl2);
        }

        private void Berechnen()
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

        private void PruefenUndBerechnen(TextBox TextBoxZahl1, TextBox TextBoxZahl2)
        {

            double zahl1, zahl2 = 0;

            //Prüfvariable
            bool ausnahme = false;

            //Prüfe Konvertierungsfehler und Division durch Null  
            try
            {
                zahl2 = Convert.ToDouble(TextBoxZahl2.Text);

                //Wenn Division wird nach dem Wert geprüft 
                if (radioButtonDivision.Checked == true)

                    if (zahl2 == 0)
                    {
                        MessageBox.Show("Zahl 2 hat einen Null Wert " + zahl2 + " Division durch Null ist nicht definiert");
                        TextBoxZahl2.Select();
                        ausnahme = true;
                    }

                try
                {
                    zahl1 = Convert.ToDouble(TextBoxZahl1.Text);

                    if (radioButtonDivision.Checked == true)

                        if (zahl1 == 0)
                        {
                            MessageBox.Show("Zahl 1 hat einen Null Wert: " + zahl1 + " Division durch Null ist nicht definiert");
                            TextBoxZahl1.Select();
                            ausnahme = true;
                        }
                }
                catch (FormatException)
                {

                    //Wenn ein Buchstabe eingegeben wird
                    MessageBox.Show("Zahl 1 hat kein gültiges Format: " + TextBoxZahl1.Text + " Bitte geben sie eine Zahl ein!");
                    TextBoxZahl1.Select();
                    ausnahme = true;
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("Zahl 2 hat kein gültiges Format: " + TextBoxZahl2.Text + " Bitte geben sie eine Zahl ein!");
                TextBoxZahl2.Select();
                ausnahme = true;
            }


            if (ausnahme == false)
            {
                Berechnen();
            }
        }
    }
}
