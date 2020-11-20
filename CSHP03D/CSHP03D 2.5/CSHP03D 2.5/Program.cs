/* ################
 switch ... case
################# */

using System;

namespace CSHP03D_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            char essenWahl, beilagenWahl;

            Console.WriteLine("Sie haben folgende Auswahl: \n");
            Console.WriteLine("a Schweineschnitzel");
            Console.WriteLine("b Wiener Schnitzel");

            Console.Write("Was möchten Sie essen? ");

            essenWahl = Convert.ToChar(Console.Read());
            //den Tastaturpuffer leeren
            Console.ReadLine();

            Console.WriteLine("Sie können folgende Beilagen wählen: \n");
            Console.WriteLine("c Pommes");
            Console.WriteLine("d Reis \n");
            Console.WriteLine("Welche Beilage möchten Sie?");

            beilagenWahl = Convert.ToChar(Console.Read());

            //Die Auswertung von essenWahl
            switch (essenWahl)
            {
                //der case-Zweig für a
                case 'A':
                case 'a':

                //die Auswertung von beilagenWahl
               switch (beilagenWahl) 
                {
                case 'C':
                case 'c':

                    Console.WriteLine("Sie haben Schweineschnitzel mit Pommes gewählt!");
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine("Sie haben Schweineschnitzel mit Reis gewählt!");
                    break;
                default:
                    Console.WriteLine("Diese Beilage gibt es nicht.");
                    break;
            }  //Hier endet die Auswertung von beilagenwahl
            
            break; //hier enden die case-Marken für a und A

                    
                    
                case 'B':
                case 'b':
                    //die Auswertung von beilagenWahl
                
                switch (beilagenWahl) 
            { 
                case 'C':
                case 'c':

                    Console.WriteLine("Sie haben Wiener Schnitzel mit Pommes gewählt!");
            break;
                case 'D':
                case 'd':
                    Console.WriteLine("Sie haben Wiener Schnitzel mit Reis gewählt!");
            break;
            default:
                    Console.WriteLine("Diese Beilage gibt es nicht.");
            break;
        }//hier endet die Asuwertung von beilagenWahl
        break; //hier enden die case-Marken für b und B
        default: //für die Auswertung von essenWahl
        Console.WriteLine("Dieses Gericht steht nicht auf der Karte.");
        break;
            }
            }

        }
    }

