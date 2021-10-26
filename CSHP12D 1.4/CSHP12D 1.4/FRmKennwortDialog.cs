namespace CSHP12D_1._4
{
    using Microsoft.Win32;
    using System;
    using System.Windows.Forms;

    public partial class FrmKennwortDialog : Form
    {
        internal int zaehler;

        public FrmKennwortDialog()
        {
            InitializeComponent();
            zaehler = 0;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            string kennwort;
            //den Wert aus der Registrierung lesen und und in
            //kennwort ablegen
            using (RegistryKey regSchluessel = Registry.CurrentUser.OpenSubKey("Software\\RegistryDemo2"))
            {
                kennwort = Convert.ToString(regSchluessel.GetValue("Kennwort"));
            }
            //stimmen die Eingabe und das Kennwort überein?
            if (textBoxKennwort.Text == kennwort)
                //das Formular schließen
                Close();
            else
            {
                MessageBox.Show("Falsches Kennwort!");
                zaehler = zaehler + 1;
                //drei falsche Eingaben?
                if (zaehler == 3)
                {
                    MessageBox.Show("Die Anwendung wird geschlossen!");
                    //die gesamte Anwendung beenden
                    Application.Exit();
                }
                else
                    //den Fokus auf das Eingabefeld setzen
                    textBoxKennwort.Select();
            }
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            //die gesamte Anwendung beenden
            Application.Exit();
        }
    }
}
