namespace CSHP12D
{
    using Microsoft.Win32;
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLesen_Click(object sender, EventArgs e)
        {
            //den Schlüssel
            //HKEY_CURRENT_USER\Software\RegistryDemo öffnen
            using (RegistryKey regSchluessel = Registry.CurrentUser.OpenSubKey("Software\\RegistryDemo"))
            {
                //wenn der Schlüssel nicht vorhanden ist, eine
                //Meldung ausgeben
                if (regSchluessel == null)
                {
                    MessageBox.Show("Der Schlüssel konnte nicht geöffnet werden!");
                    label1.Text = "Nicht vorhanden";
                }
                else
                    //sonst den Eintrag lesen und label1 zuweisen
                    label1.Text = Convert.ToString(regSchluessel.GetValue("Eintrag"));
            }
        }

        private void ButtonSchreiben_Click(object sender, EventArgs e)
        {
            //den Schlüssel HKEY_CURRENT_USER\Software\RegistryDemo
            //anlegen bzw. öffnen
            using (RegistryKey regSchluessel = Registry.CurrentUser.CreateSubKey("Software\\RegistryDemo"))
            {
                //den Wert aus dem Eingabefeld in den Eintrag schreiben
                regSchluessel.SetValue("Eintrag", textBox1.Text);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //beim Schließen speichern wir die Position und die
            //Größe in der Registrierung
            //den Schlüssel HKEY_CURRENT_USER\Software\RegistryDemo
            //anlegen bzw. öffnen
            using (RegistryKey regSchluessel = Registry.CurrentUser.CreateSubKey("Software\\RegistryDemo"))
            {
                //die Werte speichern
                regSchluessel.SetValue("Top", this.Top);
                regSchluessel.SetValue("Left", this.Left);
                regSchluessel.SetValue("Width", this.Width);
                regSchluessel.SetValue("Height", this.Height);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //beim Anzeigen lesen wir die Daten wieder zurück
            //den Schlüssel HKEY_CURRENT_USER\Software\RegistryDemo öffnen
            using (RegistryKey regSchluessel = Registry.CurrentUser.OpenSubKey("Software\\RegistryDemo"))
            {
                //wenn der Schlüssel nicht vorhanden ist, Meldung ausgeben
                if (regSchluessel == null)
                    MessageBox.Show("Der Schlüssel konnte nicht geöffnet werden!");
                else
                {
                    //sonst die Einsträge lesen und zuweisen
                    this.Top = Convert.ToInt32(regSchluessel.GetValue("Top"));
                    this.Left = Convert.ToInt32(regSchluessel.GetValue("Left"));
                    this.Width = Convert.ToInt32(regSchluessel.GetValue("Width"));
                    this.Height = Convert.ToInt32(regSchluessel.GetValue("Height"));

                }
            }
        }
    }
}
