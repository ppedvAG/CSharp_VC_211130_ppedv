using System;

namespace Taschenrechner2
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
                double zahl1, zahl2;

                Console.WriteLine();

                //Eingabe und Parsing der ersten Zahl
                do
                    Console.Write("Gib eine Zahl ein: ");
                while (!double.TryParse(Console.ReadLine(), out zahl1));

                //Eingabe und Parsing der zweiten Zahl
                do
                    Console.Write("Gib eine weitere Zahl ein: ");
                while (!double.TryParse(Console.ReadLine(), out zahl2));

                //Anzeige der möglichen Rechenoperationen
                Console.WriteLine("\nWähle eine Rechenoperation:");
                for (int i = 1; i <= Enum.GetValues(typeof(Rechenoperation)).Length; i++)
                {
                    Console.WriteLine($"{i}: {(Rechenoperation)i}");
                }

                //Abfrage der Benutzereingabe
                int op;
                do
                    Console.Write("Auswahl: ");
                while (!int.TryParse(Console.ReadLine(), out op));
                Rechenoperation operation = (Rechenoperation)op;

                //Deklaration und Initialisierung der Ergebnisvariablen
                double ergebnis = Berechne(zahl1, zahl2, operation, out string symbol);

                if (ergebnis.Equals(double.NaN))
                    Console.WriteLine("\nFehlerhafte Eingabe der Rechenoperation");
                else if (ergebnis == double.PositiveInfinity || ergebnis == double.NegativeInfinity)
                    Console.WriteLine("\nEine Teilung durch 0 ist nicht möglich");
                else
                    //Ausgabe des Ergebnisses
                    Console.WriteLine($"\nErgebnis: {zahl1} {symbol} {zahl2} = {ergebnis}");

                //Frage nach der Wiederholung des Programms
                Console.WriteLine("\nWiederholen? (Y/N) ");
                //Schleifenbedingungsprüfung anhand Tastendruck des Benutzers
            } while (Console.ReadKey(true).Key == ConsoleKey.Y);
        }

        static double Berechne(double z1, double z2, Rechenoperation o, out string symbol)
        {
            //Initialisierung der out-Variablen auf einen leeren String
            symbol = "";
            symbol = string.Empty;

            //Switch zur Auswahl der Rechenoperation
            switch (o)
            {
                //Berechnung des Ergebnisses
                case Rechenoperation.Addition:
                    symbol = "+";
                    return Addiere(z1, z2);
                case Rechenoperation.Subtraktion:
                    symbol = "-";
                    return Subtrahiere(z1, z2);
                case Rechenoperation.Multiplikation:
                    symbol = "*";
                    return Multipliziere(z1, z2);
                case Rechenoperation.Division:
                    symbol = "/";
                    return Dividiere(z1, z2);
                default:
                    //Fall, welcher eintrifft, wenn keine valide Rechenoperation ausgewählt wurde
                    return double.NaN;
            }
        }

        //Funktionen für eigentliche Berechnung
        static double Dividiere(double zahl1, double zahl2)
        {
            return zahl1 / zahl2;
        }

        static double Multipliziere(double zahl1, double zahl2)
        {
            return zahl1 * zahl2;
        }

        static double Subtrahiere(double zahl1, double zahl2)
        {
            return zahl1 - zahl2;
        }

        static double Addiere(double zahl1, double zahl2)
        {
            return zahl1 + zahl2;
        }               
    }
}
