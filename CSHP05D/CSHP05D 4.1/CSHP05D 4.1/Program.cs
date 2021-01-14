using System;

namespace CSHP05D_4._1
{

    class Behaelter
    {
        int fuellstand;
        Behaelter andererBehaelter;


        public void Init(int menge)
        {
            fuellstand = menge;
        }

        public void VerbindenMit(Behaelter behaelter)
        {
            andererBehaelter = behaelter;
        }
        public int GetFuellstand()
        {
            return fuellstand;
        }

        public int Aufnehmen(int menge)
        {
            int rueckgabe;
            if (menge + fuellstand > 100)
            {
                rueckgabe = 100 - fuellstand;
                fuellstand = 100;
            }
            else
            {
                fuellstand = fuellstand + menge;
                rueckgabe = menge;
            }
            return rueckgabe;
        }

        public void Abgeben(int menge)
        {
            int gepumt;
            if (menge > fuellstand)
                gepumt = andererBehaelter.Aufnehmen(fuellstand);
            else
                gepumt = andererBehaelter.Aufnehmen(menge);
            fuellstand = fuellstand - gepumt;

        }
    }


    class Program
    {
        static void Ausgabe(Behaelter behaelter1, Behaelter behaelter2)
        {
            Console.WriteLine("Behälter 1 --------------- Behälter 2");
            Console.Write(behaelter1.GetFuellstand());
            Console.Write("------------------------");
            Console.WriteLine(behaelter2.GetFuellstand());
        }
        static void Main(string[] args)
        {
            Behaelter behaelter1 = new Behaelter();
            Behaelter behaelter2 = new Behaelter();

            behaelter1.Init(60);
            behaelter2.Init(60);

            behaelter1.VerbindenMit(behaelter2);
            behaelter2.VerbindenMit(behaelter1);

            Ausgabe(behaelter1, behaelter2);

            behaelter1.Abgeben(10);
            Ausgabe(behaelter1, behaelter2);

            behaelter1.Abgeben(40);
            Ausgabe(behaelter1, behaelter2);

            behaelter2.Abgeben(60);
            Ausgabe(behaelter1, behaelter2);

        }
    }
}
