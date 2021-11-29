namespace CSHP13D_1._1
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLaden_Click(object sender, EventArgs e)
        {
            //wenn die Datei existiert, in die RichTextBox
            //laden
            if (System.IO.File.Exists("C:\\test\\demo.rtf"))
            {
                //den alten Inhalt löschen
                richTextBox1.Clear();
                richTextBox1.LoadFile("C:\\test\\demo.rtf");
            }
            //sonst eine Meldung anzeigen
            else
            {
                MessageBox.Show("Bitte speichern Sie zuerst einen Text.");
            }
        }

        private void ButtonSpeichern_Click(object sender, EventArgs e)
        {
            //den Text aus der RichTextBox speichern
            richTextBox1.SaveFile("C:\\test\\demo.rtf");
        }
    }
}
