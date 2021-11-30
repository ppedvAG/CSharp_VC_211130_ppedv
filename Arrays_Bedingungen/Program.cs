using System;
using System.Linq;

namespace Array_Bedingungen
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays

            //ARRAYS
            ///Arrays sind Collections, welche mehrere Variablen eines Datentyps speichern können. Die Größe des Arrays muss bei der
            ///Initialisierung entweder durch eine Zahl oder durch eine bestimmte Anzahl von spezifischen Elementen definiert werden.
            int[] zahlen = { 2, 4, 78, -123, -8, 0, 11111 };
            //Der Zugiff auf einzelne Array-Positionen erfolgt durch einen Nullbasierten Index
            Console.WriteLine(zahlen[2]);
            zahlen[2] = 1234;
            Console.WriteLine(zahlen[2]);

            //Array-Deklaration ohne direkte Initialisierung der Positionen (Größe muss angegeben werden)
            string[] worte = new string[5];

            //Verwendung der Contains-Funktion eines Arrays (überprüft auf das Vorhandensein eines Elements)
            Console.WriteLine(zahlen.Contains(-123));
            Console.WriteLine(zahlen.Contains(555));

            //Ausgabe der Länge (Anzahl der Elemente) des Arrays
            Console.WriteLine(zahlen.Length);

            //Stringarray mit 10 leeren Plätzen
            string[] Wörter = new string[10];

            //String als Char-Array
            string beispiel = "Hallo";
            Console.WriteLine(beispiel[2]);

            //Mehrdimensionales Array
            int[,] zweiDimArray = new int[3, 5];
            zweiDimArray[0, 0] = 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    zweiDimArray[i, j] = i * j;
                }
            }
            Console.WriteLine(zweiDimArray[2, 3]);
            #endregion



            #region Bedingungen (If/Else)

            //Deklaration und Initialisierung von Beispiel-Variablen
            int a = 23;
            int b = 23;

            //IF-ELSEIF-ELSE-Block
            ///Das Programm wird den ersten Block ausführen, bei welchem er auf eine wahre Bedingung trifft und dann am Ende des Blocks mit
            ///dem Code weiter machen
            if (a < b)
            {
                Console.WriteLine("A ist kleiner als B");
            }
            //Es kann beliebig viele ELSE-IF-Blöcke geben
            else if (a > b)
            {
                Console.WriteLine("A ist größer als B");
            }
            //Wenn keine der Bedingungen wahr ist, wird der (optionale) ELSE-Block ausgeführt
            else
                Console.WriteLine("A ist gleich B");

            //Kurznotation:
            //(Bedingung) ? TrueAusgabe : FalseAusgabe
            string ergebnis = (a == b) ? "A ist gleich B" : "A ist ungleich B";

            //Bsp eines String-Vergleichs
            string name1 = "Hans";
            string name2 = "Hans";

            if (name1.Equals(name2))
            {
                Console.WriteLine("Gleich");
            }

            #endregion

        }
    }
}
