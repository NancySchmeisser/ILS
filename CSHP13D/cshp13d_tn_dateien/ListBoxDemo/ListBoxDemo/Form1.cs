using System;
using System.Windows.Forms;
using System.IO;

namespace ListBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSpeichern_Click(object sender, EventArgs e)
        {
            //eine neue Instanz von StreamWriter erzeugen
            using (StreamWriter textDatei = new StreamWriter("c:\\test\\daten.txt"))
            {
                //alle Daten in der ListBox in die Datei schreiben
                for (int i = 0; i < listBox1.Items.Count; i++)
                    textDatei.WriteLine(listBox1.Items[i].ToString());
            }
        }

        private void ButtonLaden_Click(object sender, EventArgs e)
        {
            //existiert die Datei?
            if (File.Exists("c:\\test\\daten.txt"))
            {
                //eine neue Instanz von StreamReader erzeugen
                using (StreamReader textDatei = new StreamReader("c:\\test\\daten.txt"))
                {
                    //für die Zeilen in der Datei
                    string zeile;
                    //die ListBox leeren
                    listBox1.Items.Clear();
                    //solange das Ende der Datei nicht erreicht ist, die Daten lesen und in die ListBox schreiben
                    while (textDatei.EndOfStream == false)
                    {
                        zeile = textDatei.ReadLine();
                        listBox1.Items.Add(zeile);
                    }
                }
            }
        }

        private void ButtonEinfuegen_Click(object sender, EventArgs e)
        {
            //steht etwas im Textfeld?
            //dann kopieren wir das in die ListBox
            if (textBox1.Text != string.Empty)
                listBox1.Items.Add(textBox1.Text);
        }
    }
}
