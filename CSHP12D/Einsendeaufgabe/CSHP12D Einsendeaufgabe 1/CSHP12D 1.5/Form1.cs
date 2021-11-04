namespace CSHP12D_1._5
{
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

    public partial class Form1 : Form
    {
        internal RegistryKey regSchluessel;

        internal string[] regSchluesselListe;

        internal string[] regEintragListe;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonEinlesen_Click(object sender, EventArgs e)
        {
            //den Inhalt der drei Listenfelder löschen
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            //die Schlüssel aus HKEY_CURRENT_USER holen
            regSchluesselListe = Registry.CurrentUser.GetSubKeyNames();
            //und in das erste Listenfeld eintragen
            foreach (string eintrag in regSchluesselListe)
                listBox1.Items.Add(eintrag);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            //den Schlüssel des ausgewählten Eintrag öffnen
            regSchluessel = Registry.CurrentUser.OpenSubKey(listBox1.SelectedItem.ToString());
            regSchluesselListe = regSchluessel.GetSubKeyNames();

            //in das zweite Listenfeld eintragen
            foreach (string eintrag in regSchluesselListe)
                listBox2.Items.Add(eintrag);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            string Schluessel = listBox1.SelectedItem.ToString() + "\\" + listBox2.SelectedItem.ToString();
            regSchluessel = Registry.CurrentUser.OpenSubKey(Schluessel);
            if (regSchluessel == null)
            {
                MessageBox.Show("Keine weiteren Schlüssel");
            }
            else
            {
                regEintragListe = regSchluessel.GetValueNames();
                foreach (string eintrag in regEintragListe)
                    if (regEintragListe == null)
                    {
                        MessageBox.Show("Keine weiteren Schlüssel");
                    }
                    else

                        listBox3.Items.Add(eintrag + " = " + Convert.ToString(regSchluessel.GetValueKind(eintrag)));
            }
        }

        private void ButtonBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
