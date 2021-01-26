using System;

namespace CSHP06D_Einsendeaufgabe_6
{
	class Insekt
	{
		protected int laenge;
		protected int gewicht;

		//der Konstruktor
		public Insekt(int laenge, int gewicht)
		{
			this.laenge = laenge;
			this.gewicht = gewicht;
		}

		//die Methode zum Essen
		public virtual void Essen()
		{
			laenge = laenge + 1;
			gewicht = gewicht + 1;
		}

		//die Methode zur Ausgabe
		public virtual void Ausgabe()
		{
			Console.WriteLine("Das Insekt ist {0} cm lang und wiegt {1} Gramm.", laenge, gewicht);
		}
	}

	class Libelle : Insekt
    {
		protected int fluegellaenge;

		public Libelle(int laenge, int gewicht, int fluegellaenge) : base(laenge, gewicht)
        {
			this.fluegellaenge = fluegellaenge;
        }

		public override void Essen()
		{
			laenge = laenge + 1;
			gewicht = gewicht + 1;
			fluegellaenge = fluegellaenge + 1;
		}
		public override void Ausgabe()
		{
			Console.WriteLine("Das Insekt ist {0} cm lang und wiegt {1} Gramm. Die Flügel messen {2} Millimeter", laenge, gewicht, fluegellaenge);
		}
	}

	class Program
    {
        static void Main(string[] args)
        {
			Insekt Flik = new Insekt(2, 1);
			Libelle kleineLibelle = new Libelle(20, 2, 15);

			Flik.Ausgabe();
			Flik.Essen();
			Flik.Ausgabe();

			kleineLibelle.Ausgabe();
			kleineLibelle.Essen();
			kleineLibelle.Ausgabe();
        }
    }
}
