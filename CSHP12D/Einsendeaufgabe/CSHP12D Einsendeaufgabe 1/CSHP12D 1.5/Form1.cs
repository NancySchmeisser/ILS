namespace CSHP12D_1._5
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

        private void ButtonEinlesen_Click(object sender, EventArgs e)
        {
            //den Inhalt der drei Listenfelder löschen
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            //die Schlüssel aus HKEY_CURRENT_USER holen
            string[] regSchluesselListe = Registry.CurrentUser.GetSubKeyNames();
            //und in das erste Listenfeld eintragen
            foreach (string eintrag in regSchluesselListe)
                listBox1.Items.Add(eintrag);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            //den Schlüssel des ausgewählten Eintrag öffnen
            RegistryKey regSchluessel = Registry.CurrentUser.OpenSubKey(listBox1.SelectedItem.ToString());
            string[] regSchluesselListe = regSchluessel.GetSubKeyNames();

            //in das zweite Listenfeld eintragen
            foreach (string eintrag in regSchluesselListe)
                listBox2.Items.Add(eintrag);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            string Schluessel = listBox1.SelectedItem.ToString() + "\\" + listBox2.SelectedItem.ToString();
            RegistryKey regSchluessel = Registry.CurrentUser.OpenSubKey(Schluessel);

            string[] regEintragListe = regSchluessel.GetSubKeyNames();
            foreach (string eintrag in regEintragListe)
            {
                listBox3.Items.Add(eintrag);
            }

            string[] regValueNames = regSchluessel.GetValueNames();
            foreach (string valueName in regValueNames)
            {
                object value = regSchluessel.GetValue(valueName);
                listBox3.Items.Add(valueName + " = " + Convert.ToString(value));
            }

            if (listBox3.Items.Count == 0)
            {
                MessageBox.Show("Keine weiteren Schlüssel oder Werte");
            }
        }

        private void ButtonBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
