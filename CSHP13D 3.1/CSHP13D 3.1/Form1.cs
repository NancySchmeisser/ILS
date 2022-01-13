using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSHP13D_3._1
{
    public partial class Form1 : Form
    {
        private object listBox1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSpeichern_Click(object sender, EventArgs e)
        {
            //eine neue Instanz von StreamWriter erzeugen
            StreamWriter textDatei = new StreamWriter("c:\\test\\daten\\daten.text");
            //alle Daten in der Listbox in die Datei schreiben
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                textDatei.WriteLine(listBox1.Items[i].ToString());
                //die Datei wieder schließen
                textDatei.Close();
            }


        }

    }
}
