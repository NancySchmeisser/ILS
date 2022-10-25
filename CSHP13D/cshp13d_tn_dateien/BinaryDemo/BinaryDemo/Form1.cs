using System;
using System.Windows.Forms;
using System.IO;

namespace BinaryDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSpeichern_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //eine neue Instanz von FileStream erzeugen
                //die Datei soll entweder geöffnet oder neu erzeugt werden
                using (FileStream fStream = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate))
                {
                    //eine neue Instanz von BinaryWriter auf der Basis von fStream erzeugen
                    //das Erzeugen erfolgt in einem eigenen using-Block
                    using (BinaryWriter binaerDatei = new BinaryWriter(fStream))
                    {
                        //die Zahlen von 0 bis 19 in die Datei schreiben
                        for (int i = 0; i < 20; i++)
                            binaerDatei.Write(i);
                    }
                }
            }
        }

        private void ButtonLaden_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                //eine neue Instanz von FileStream erzeugen
                //die Datei soll nur geöffnet erzeugt werden
                using (FileStream fStream = new FileStream(openFileDialog1.FileName, FileMode.Open))
                {
                    //eine neue Instanz von BinaryReader auf der Basis von fStream erzeugen
                    using (BinaryReader binaerDatei = new BinaryReader(fStream))
                    {
                        //die Zahlen auslesen und in das Listenfeld schreiben
                        for (Int32 i = 0; i < 20; i++)
                            listBox1.Items.Add(binaerDatei.ReadInt32());
                    }
                }
            }
        }
    }
}
