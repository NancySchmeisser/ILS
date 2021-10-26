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
    public partial class FrmNeuesKennwort : Form
    {
        public FrmNeuesKennwort()
        {
            InitializeComponent();
        }

        private void ButtonUebernehmen_Click(object sender, EventArgs e)
        {
            //ist das erste Feld leer?
            if (textBoxKennwort1.Text == string.Empty)
            {
                MessageBox.Show("Das Kennwort muss mindestens ein Zeichen lang sein!");
                //den Fokus auf das erste Feld setzen
                textBoxKennwort1.Select();
                return;
            }
            //stimmen die beiden Einträge überein
            if (textBoxKennwort1.Text == textBoxKennwort2.Text)
            {
                //den Wert in die Registrierung schreiben
                using (RegistryKey regSchluessel = Registry.CurrentUser.CreateSubKey("Software\\RegistryDemo2"))
                {
                    regSchluessel.SetValue("Kennwort", textBoxKennwort1.Text);
                }
                //das Formular schließen
                Close();
            }
            else
            {
                MessageBox.Show("Die Eingaben stimmen nicht überein!");
                //den Fokus auf das zweite Eingabefeld setzen
                textBoxKennwort2.Select();
            }
        }
    }
}
