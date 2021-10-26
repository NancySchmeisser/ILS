using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHP12D_1._4
{
    public partial class FrmKennwortDialog : Form
    {
        //ein eigenes Feld zum Zählen
        //es wird im Konstruktor auf 0 gesetzt
        int zaehler = 0;
        public FrmKennwortDialog()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            string kennwort;
            //den Wert aus der Registrierung lesen und und in
            //kennwort ablegen
            using (RegistryKey regSchluessel = Registry.CurrentUser.OpenSubKey("Software\\RegistryDemo2"))
            {
                kennwort = Convert.ToString
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
