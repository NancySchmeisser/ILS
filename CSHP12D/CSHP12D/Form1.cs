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

namespace CSHP12D
{
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
    }
}
