using System;

namespace Schleifen_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Schleifen

            int a = 0;
            int b = 10;

            //WHILE-Schleife
            ///Die WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Ist die Bedingung von vornherein unwahr, dann wird die Schleife
            ///übersprungen
            while (a < b)
            {
                Console.WriteLine("A ist kleiner B");
                a++;

                //Mit der BREAK-Anweisung wird die Schleife verlassen und der Code wird fortgesetzt.
                if (a == 5)
                    break;
            }
            Console.WriteLine("Schleifenende");

            a = -45;
            //DO-WHILE-Schleife
            ///Auch die DO-WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Allerdings wird die Bedingung erst am Schleifen_
            ///ende geprüft, weshalb die Schleife mindestens einmal durchläuft.
            do
            {
                Console.WriteLine(a);
                a--;

                //Der CONTINUE-Befehl beendet den aktuellen Schleifendurchlauf und lässt erneut die Bedingung prüfen. Ist die Bedingung wahr
                ///beginnt ein neuer Durchlauf
                continue;

            } while (a > 0);


            //FOR-Schleife
            ///Der FOR-Schleife wird ein Laufindex (i) sowie eine Bedingung und eine Anweisung übergeben. Am Ende jedes Durchlaufes wird die
            ///Anweisung ausgeführt. Wenn die Bedingung nicht (mehr) wahr ist, wird kein (weiterer) Schleifendurchlauf begonnen.
            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine(i);

                i++;
            }

            int[] zahlen = { 2, 3, 5, 4 };
            //Iteration über ein Array mittels For-Schleife
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine(zahlen[i]);
            }

            //FOREACH-Schleifen können über Collections laufen und sprechen dabei jedes Element genau einmal an
            foreach (int item in zahlen)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Enums

            //ENUMERATOREN sind spezialisierte selbst-definierte Datentypen mit festgelegten möglichen Zuständen.
            ///Dabei ist jeder Zustand an einen Integer-Wert gekoppelt, wodurch eine explizite Umwandlung (Cast) möglich ist. (vgl. Datentyp-Definition unten)

            //Deklaration und Initialisierung einer Variablen vom Enumerator-Typ
            Wochentag heutigerTag = Wochentag.Dienstag;
            Console.WriteLine($"Heute ist also {heutigerTag}.");

            //For-Schleife über die möglichen Zustande des Enumerators
            Console.WriteLine("Welcher Wochentag ist dein Lieblingstag?");
            for (int i = 1; i < Enum.GetValues(typeof(Wochentag)).Length; i++)
            {
                Console.WriteLine($"{i}: {(Wochentag)i}");
            }
            //Speichern einer Benutzereingabe (Int) als Enumerator
            //Cast: Int -> Wochentag
            heutigerTag = (Wochentag)int.Parse(Console.ReadLine());
            Console.WriteLine($"Dein Lieblingstag ist also {heutigerTag}.");

            //Parsing eines Strings in den Enumzustand
            heutigerTag = (Wochentag)Enum.Parse(typeof(Wochentag), "Freitag");
            Console.WriteLine($"Dein Lieblingstag ist also {heutigerTag}.");

            //SWITCHs sind eine verkürzte Schreibweise für IF-ELSE-Blöcke. Mögliche Zustände der übergebenen Variablen werden 
            //in den CASES definiert
            switch (heutigerTag)
            {
                case Wochentag.Montag:
                    Console.WriteLine("Wochenstart");
                    //Jeder speziell definierte CASE muss mit einer BREAK-Anweisung beendet werden
                    break;
                //Wenn in einem CASE keine Anweisungen geschrieben stehen kann auf den BREAK-Befehl verzichtet werden. In diesem Fall
                //springt das Programm in diesem CASE zum Nachfolgenden
                case Wochentag.Dienstag:
                case Wochentag.Mittwoch:
                case Wochentag.Donnerstag:
                    Console.WriteLine("Normaler Wochentag");
                    break;
                case Wochentag.Freitag:
                case Wochentag.Samstag:
                case Wochentag.Sonntag:
                    Console.WriteLine("Wochenende");
                    break;
                //Wenn die übergebene Variable keinen der vordefinierten Zustände erreicht, wird der DEFAULT-Fall ausgeführt
                default:
                    Console.WriteLine("Fehlerhafte Eingabe");
                    break;
            }

            //Mittels des WHEN-Stichworts kann auf Eigenschaften des betrachteten Objekts näher eingegangen werden
            int zahl = -45;
            switch (zahl)
            {
                case 5:
                    Console.WriteLine("a ist 5");
                    break;
                //zahl wird in z eingelegt (zu überprüfende Variable wird für Bedingungsprüfung vorbereitet)
                //und mittels when auf eine Eigenschaft geprüft
                case int z when z < 0:
                    Console.WriteLine("a < 0");
                    break;
                default:
                    break;
            }
            #endregion

        }
    }

    //Enum-Definition (vgl. Verwendung oben)
    enum Wochentag { Montag = 1, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag }

}
