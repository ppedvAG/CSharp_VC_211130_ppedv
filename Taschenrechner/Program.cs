using System;
using System.Linq;

namespace Taschenrechner
{
    class Program
    {
        //Enum-Definition
        enum Rechenoperation { Addition = 1, Subtraktion, Multiplikation, Division }

        static void Main(string[] args)
        {
            //Schleife für Programm-Wiederholung
            do
            {
                //Eingabe und Parsing der ersten Zahl
                Console.Write("\nGib eine Zahl ein: ");
                double zahl1 = double.Parse(Console.ReadLine());

                //Eingabe und Parsing der zweiten Zahl
                Console.Write("Gib eine weitere Zahl ein: ");
                double zahl2 = double.Parse(Console.ReadLine());

                //Anzeige der möglichen Rechenoperationen
                Console.WriteLine("\nWähle eine Rechenoperation:");
                for (int i = 1; i <= Enum.GetValues(typeof(Rechenoperation)).Length; i++)
                {
                    Console.WriteLine($"{i}: {(Rechenoperation)i}");
                }
                //Abfrage der Benutzereingabe
                Console.Write("Auswahl: ");
                Rechenoperation op = (Rechenoperation)int.Parse(Console.ReadLine());

                //Deklaration und Initialisierung der Ergebnisvariablen
                double ergebnis = 0.0;

                //Switch zur Auswahl der Rechenoperation
                switch (op)
                {
                    //Berechnung des Ergebnisses
                    case Rechenoperation.Addition:
                        ergebnis = zahl1 + zahl2;
                        break;
                    case Rechenoperation.Subtraktion:
                        ergebnis = zahl1 - zahl2;
                        break;
                    case Rechenoperation.Multiplikation:
                        ergebnis = zahl1 * zahl2;
                        break;
                    case Rechenoperation.Division:
                        //Prüfung einer möglichen Teilung durch null
                        if (zahl2 == 0.0)
                        {
                            Console.WriteLine("\nEine Division durch 0 ist nicht erlaubt.");
                            Console.WriteLine("Wiederholen? (Y/N) ");
                            //Sprung zur Schleifenprüfung
                            continue;
                        }
                        ergebnis = zahl1 / zahl2;
                        break;
                    default:
                        //Fall, welcher eintrofft, wenn keine valide Rechenoperation ausgewählt wurde
                        Console.WriteLine("\nFehlerhafte Eingabe bei Auswahl der Rechenoperation");
                        Console.WriteLine("Wiederholen? (Y/N) ");
                        continue;

                }

                //Ausgabe des Ergebnisses
                Console.WriteLine($"\nErgebnis: {ergebnis}");

                //Frage nach der Wiederholung des Programms
                Console.WriteLine("Wiederholen? (Y/N) ");
                //Schleifenbedingungsprüfung anhand Tastendruck des Benutzers
            } while (Console.ReadKey(true).Key == ConsoleKey.Y);
        }
    }
}


