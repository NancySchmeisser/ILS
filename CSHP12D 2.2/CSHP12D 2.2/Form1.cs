using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CSHP12D_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //eine neue Instanz für XMLReader über Create() erzeugen
            XmlReader xmlLesen = XmlReader.Create("c:\\test\\test.xml");
            //solange Daten gelesen werden können
            while (xmlLesen.Read())
                //den Wert in das Listenfeld schreiben
                listBox1.Items.Add(xmlLesen.Value);
            //die Datei wieder schließen
            xmlLesen.Close();
        }
    }
}
