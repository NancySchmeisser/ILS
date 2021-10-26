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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            using (RegistryKey regSchluessel = Registry.CurrentUser.OpenSubKey("Software\\RegistryDemo2"))
            {
                //das Formular der eigentlichen Anwendung ausblenden
                this.Hide();
                //wenn es den Schlüssel nicht gibt, das Formular
                //zum Festlegen des Kennworts anzeigen
                if (regSchluessel == null)
                {
                    FrmNeuesKennwort dialogNeu = new FrmNeuesKennwort();
                    dialogNeu.ShowDialog();
                }
                //sonst das Formular zur Eingabe des Kennworts anzeigen
                else
                {
                    FrmKennwortDialog dialogEingabe = new FrmKennwortDialog();
                    dialogEingabe.ShowDialog();
                }
            }
            //das Formular der eigentlichen Anwendung zeigen
            this.Show();
        }

        private void ButtonLoeschen_Click(object sender, EventArgs e)
        {
            //den gesamten Zweig in der Registrierung löschen
            Registry.CurrentUser.DeleteSubKeyTree("Software\\RegistryDemo2");
        }
    }
}
