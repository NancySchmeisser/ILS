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

namespace CSHP12D_2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //den Namen aus der ausführbaren Datei ableiten
            xmlName = System.IO.Path.ChangeExtension(Application.ExecutablePath, ".xml");
            //prüfen, ob es die Datei bereits gibt
            xmlVorhanden = System.IO.File.Exists(xmlName);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //die Anzeige in den Labels setzen
            labelName.Text = XmlNamedNodeMap;
            if (xmlVorhanden == true)
                labelVorhanden.Text = "Ja";
            else
                labelVorhanden.Text = "Nein";
        }
    }
}
