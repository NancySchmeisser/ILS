using System;
using System.IO;

namespace CSHP13D_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
            //eine neue Instanz von Filestream erzeugen
            //die Datei soll entweder geöffnet oder neu erzeugt werden
            using (Filestream fStream = new FileStream(saveFileDialog1.Filename, FileMode.OpenOrCreate))
            {
            //eine neue Instanz von Binary Writer auf der Basis von fStream erzeugen
            //das Erzeugen erfolgt in einem eigenen Using Block
            using (BinaryWriter binaerDatei = new BinaryWriter(fStream))
            {
            //die Zahlen von 0 bis 19 in die Datei schreiben
            for (int i = 0; i< 20; i++)
            binaerDatei.Write(i);
            }
}
}
