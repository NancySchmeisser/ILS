using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace CSHP12D_Einsendeaufgabe_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSpeichern_Click(object sender, EventArgs e)
        {
            var directory =  Path.GetDirectoryName(Application.ExecutablePath);
            var fileName = Path.Combine(directory, "liste.xml");
            XmlWriter xmlSpeichern = XmlWriter.Create(fileName);
            xmlSpeichern.WriteStartDocument();
            xmlSpeichern.WriteStartElement("liste");
            for(int i = 0; i< listBox1.Items.Count; i++)
            {
                xmlSpeichern.WriteElementString("Wert" + (i + 1), listBox1.Items[i].ToString());
            }
            xmlSpeichern.WriteEndElement();
            xmlSpeichern.WriteEndDocument();
            xmlSpeichern.Close();
        }

        private void ButtonUebernehmen_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }
    }
}
