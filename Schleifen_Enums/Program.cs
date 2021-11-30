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

        }
    }
}