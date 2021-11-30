using System;
using System.Linq;

namespace Schaltjahrrechner_MiniLotto
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.Aufgabe: Schaltjahr-Rechner

            //Abfrage der Eingabe
            Console.WriteLine("Gib das Jahr ein:");
            int eingabe = int.Parse(Console.ReadLine());

            //Deklarierung/Initialisierung der bool-Variablen
            bool istSchaltjahr = false;

            //Prüfung einer Teilbarkeit durch 4
            if (eingabe % 4 == 0)
            {
                //Setzten der Variablen auf true
                istSchaltjahr = true;

                //Prüfung einer Teilbarkeit durch 100
                if (eingabe % 100 == 0)
                {
                    //Setzten der Variablen auf false
                    istSchaltjahr = false;

                    //Prüfung einer Teilbarkeit durch 400
                    if (eingabe % 400 == 0)
                        //Setzten der Variablen auf true
                        istSchaltjahr = true;
                }
            }

            //Ausgabe
            Console.WriteLine($"{eingabe} ist Schaltjahr: {istSchaltjahr}");

            //Alternative (detailiertere) Ausgabe mittels Kurz-Bedingung
            string ausgabe = istSchaltjahr ? $"{eingabe} ist ein Schaltjahr." : $"{eingabe} ist kein Schaltjahr.";
            Console.WriteLine(ausgabe + "\n\n\n");

            #endregion


            #region 2. Aufgabe: Mini-Lotto

            //Deklaration & Initialisierung des Arrays der Gewinnzahlen
            int[] gewinnzahlen = { 3, 16, 45, 79, 99 };

            //Abfrage des User-Tipps
            Console.Write("Bitte gib deinen Tipp ab (Ganzzahl zwischen 0 und 100): ");
            int tipp = int.Parse(Console.ReadLine());

            //Prüfung des Zahlenbereiches des Tipps
            if (tipp < 0 || tipp > 100)
                Console.WriteLine("Dein Tipp ist außerhalb des Zahlenbereiches.");
            else
            {
                //Prüfung, ob Tipp eine Gewinnzahl ist und Ausgabe
                if (gewinnzahlen.Contains(tipp))
                    Console.WriteLine("Glückwunsch!! Du hast eine der fünf Gewinnzahlen getippt.");
                else
                    Console.WriteLine("Leider daneben. Viel Glück beim nächsten Mal.");
            } 
            #endregion
        }
    }
}
