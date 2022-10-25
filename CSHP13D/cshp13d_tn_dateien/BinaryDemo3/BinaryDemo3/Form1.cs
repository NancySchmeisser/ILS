using System;
using System.Windows.Forms;
using System.IO;

namespace BinaryDemo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //die Datei demo.dat mit int-Werten füllen
            using (FileStream fStream = new FileStream(Application.StartupPath + "\\demo.dat", FileMode.Create))
            {
                using (BinaryWriter binaerDatei = new BinaryWriter(fStream))
                {
                    for (int i = 0; i < 30; i++)
                        binaerDatei.Write(i);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //befindet sich ein Eintrag im Feld?
            if (textBox1.Text == String.Empty)
                return;
            //gibt es die Datei?
            if (File.Exists(Application.StartupPath + "\\demo.dat"))
            {
                int neuePosition;
                neuePosition = Convert.ToInt32(textBox1.Text);
                using (FileStream fStream = new FileStream(Application.StartupPath + "\\demo.dat", FileMode.Open))
                {
                    using (BinaryReader binaerDatei = new BinaryReader(fStream))
                    {
                        //ist die Position gültig?
                        if (neuePosition <= fStream.Length - 4)
                        {
                            //positionieren
                            fStream.Position = neuePosition;
                            //dann lesen und anzeigen
                            labelWert.Text = Convert.ToString(binaerDatei.ReadInt32());
                        }
                    }
                }
            }
        }
    }
}
