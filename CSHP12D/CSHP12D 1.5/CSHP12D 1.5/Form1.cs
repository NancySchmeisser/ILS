﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHP12D_1._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonEinlesen_Click(object sender, EventArgs e)
        {
            //ein Array mit Zeichenketten für die Schlüssel
            string[] regSchluesselListe;
            //ein Array mit Zeichenketten für die Einträge
            string[] regEintragListe;
            //den Inhalt der drei Listenfelder löschen
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            //die Schlüssel aus HKEY_CURRENT_USER holen
            regSchluesselListe = Registry.CurrentUser.GetSubKeyNames();
            //und in das erste Listenfeld eintragen
            foreach (string eintrag in regSchluesselListe)
                listBox1.Items.Add(eintrag);
            
            //den Schlüssel Software öffnen
            using (RegistryKey regSchluessel = Registry.CurrentUser.OpenSubKey("Software"))
            {
                //und jetzt alle Unterschlüssel für Software lesen
                regSchluesselListe = regSchluessel.GetSubKeyNames();
            }
            //in das zweite Listenfeld eintragen
            foreach (string eintrag in regSchluesselListe)
                listBox2.Items.Add(eintrag);

            //den Schlüssel \Software\Registrierungsdemo öffnen
            using (RegistryKey regSchluessel = Registry.CurrentUser.OpenSubKey("Software\\RegistryDemo"))
            {
                //die Einträge lesen
                regEintragListe = regSchluessel.GetValueNames();
                //die Namen und die Werte in das dritte Listenfeld schreiben
                foreach (string eintrag in regEintragListe)
                    listBox3.Items.Add(eintrag + " = " + Convert.ToString(regSchluessel.GetValue(eintrag)));
            }
        }
    }
}
