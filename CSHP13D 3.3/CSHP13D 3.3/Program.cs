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

        //eine neue Instanz von Filestream erzeugen
        //die Datei soll nur geöffnet erzeugt werden
        using(FileStream fStream = new Filestream(openFileDialog1.Filename, FileMode.Open))
    {
        //eine neue Instanz von BinaryReader auf der Basis von fStream erzeugen
        using(BinaryReader binaerDatei = new BinaryReader(fStream))
    {
        //die Zahlen auslesen und in das Listenfeld schreiben
        for (int32 i = 0; i < 20; i++)
        listbox.Items.Add(binaerDatei.ReadInt32());

        
    }
}
