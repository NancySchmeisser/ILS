using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DruckenTextdatei
{
    public partial class Form1 : Form
    {
        //ein StreamReader zum Lesen der Datei
        StreamReader textDatei = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonDrucken_Click(object sender, EventArgs e)
        {
            //gibt es die Datei überhaupt?
            if (File.Exists("C:\\test\\druckdatei.txt") == false)
                MessageBox.Show("Die Datei druckdatei.txt ist nicht vorhanden!");
            else
            {
                //eine neue Instanz von StreamReader erzeugen
                //textDatei ist als Feld der Klasse vereinbart
                try
                {
                    textDatei = new StreamReader("C:\\test\\druckdatei.txt");
                    //die Druckausgabe starten
                    printDocument1.Print();
                }
                catch (Exception)
                {
                    MessageBox.Show("Es hat ein Problem gegeben.");
                }
                finally
                {
                    //die Ressourcen freigeben
                    //dabei wird die Datei auch geschlossen
                    if (textDatei != null)
                        textDatei.Dispose();
                }
            }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //ein Pinsel für die Farbe
            SolidBrush pinsel = new SolidBrush(Color.Black);
            //für die Schriftart
            Font schrift = new Font("Arial", 12, FontStyle.Bold);
            //für die Zeilen pro Seite
            int zeilenProSeite = 0;
            //für die Y-Position der Ausgabe
            int yPos = e.MarginBounds.Top;
            //zum Mitzählen der Zeilen
            int zeilenGedruckt = 0;
            //für die Textzeile
            string zeile;
            zeile = String.Empty;
            //die Höhe des Ausgabebereichs wird durch die Höhe der Schrift geteilt
            zeilenProSeite = e.MarginBounds.Height / schrift.Height;
            //so lange noch mehr Zeilen da sind und der untere Rand nicht erreicht ist
            //wird gedruckt
            while ((zeilenGedruckt < zeilenProSeite) && (textDatei.EndOfStream == false))
            {
                //die nächste Zeile lesen
                zeile = textDatei.ReadLine();
                //die Zeile ausgeben
                e.Graphics.DrawString(zeile, schrift, pinsel, e.MarginBounds.Left, yPos);
                //die Anzahl der gedruckten Zeilen erhöhen
                zeilenGedruckt++;
                //yPos auf die nächste Ausgabeposition setzen
                yPos = yPos + schrift.Height;
            }
            //kommt noch mehr Text
            //dann die nächste Seite anfangen
            if (textDatei.EndOfStream == false)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

        private void ButtonVorschau_Click(object sender, EventArgs e)
        {
            //gibt es die Datei überhaupt?
            if (File.Exists("C:\\test\\druckdatei.txt") == false)
                MessageBox.Show("Die Datei druckdatei.txt ist nicht vorhanden!");
            else
            {
                try
                {
                    //eine neue Instanz von StreamReader erzeugen
                    //textDatei ist als Feld der Klasse vereinbart
                    textDatei = new StreamReader("C:\\test\\druckdatei.txt");
                    //die Vorschau erzeugen
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("Es hat ein Problem gegeben.");
                }
                finally
                {
                    //die Ressourcen freigeben
                    //dabei wird die Datei auch geschlossen
                    if (textDatei != null)
                        textDatei.Dispose();
                }
            }
        }
    }
}
