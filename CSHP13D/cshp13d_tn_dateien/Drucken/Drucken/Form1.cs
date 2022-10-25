using System;
using System.Drawing;
using System.Windows.Forms;

namespace Drucken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonDrucken_Click(object sender, EventArgs e)
        {
            //die Druckausgabe starten
            printDocument1.Print();
        }

        private void ButtonVorschau_Click(object sender, EventArgs e)
        {
            //das anzuzeigende Dokument setzen
            printPreviewDialog1.Document = printDocument1;
            //und den Dialog anzeigen
            printPreviewDialog1.ShowDialog();
        }

        private void ButtonBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //ein Pinsel für die Farbe
            SolidBrush pinsel = new SolidBrush(Color.Black);
            //für die Schriftart
            Font schrift = new Font("Arial", 12, FontStyle.Bold);
            //den Text auf der Zeichenfläche des Druckers ausgeben
            e.Graphics.DrawString(textBox1.Text, schrift, pinsel, 20, 20);
            //eine neue Bitmap-Grafik aus der Bitmap in der PictureBox erzeugen
            e.Graphics.DrawImage(pictureBox1.Image, new Point(20, 200));
        }
    }
}
