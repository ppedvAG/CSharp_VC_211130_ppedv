using System;

namespace Funktionen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufruf der Addiere(dbl,dbl)-Funktion
            double summe = Addiere(3, 5);
            Console.WriteLine(summe);

            //Aufruf der Params-Funktion
            int erg = BildeSumme(2, 4, 7, 9, 5);

            //Aufruf einer Funktion unter Verwendung der optionalen Parameter
            erg = Subtrahiere(10, 5, d: 2);

            //Aufruf der Out-Funktion
            int zahl = 5;
            erg = AddiereUndSubtrahiere(10, zahl, out int diff);
            //Ausgabe
            Console.WriteLine(diff);
            Console.WriteLine(erg);


            //TryParse() als Bsp für Out-Verwendung
            string eingabe = Console.ReadLine();
            if (int.TryParse(eingabe, out int result))
            {
                result = result * 5;
            }
        }

        //Jede Funktion/Methode besteht aus einem Kopf und einem Körper
        ///Der Kopf besteht aus den MODIFIERN (public static), dem RÜCKGABEWERT (int), dem NAMEN (Addiere) sowie den ÜBERGABEPARAMETERN
        static int Addiere(int a, int b)
        {
            //Der RETURN-Befehl weist die Methode an einen Wert als Rückgabewert an den Aufrufe zurückzugeben
            return a + b;
        }

        //Funktion, welche den gleichen Bezeichner haben, nennt man ÜBERLADENE Funktionen. Diese müssen sich in Anzahl und/oder Art der 
        ///Übergabeparameter unterscheiden, damit der Aufruf eindeutig ist.
        static double Addiere(double a, double b)
        {
            return a + b;
        }

        //Das PARAMS-Stichwort erlaubt die Übergabe einer beliebige Anzahl von gleichartigen Daten, welche innerhalb
        //der Methode als Array interpretiert werden
        static int BildeSumme(params int[] summanden)
        {
            int summe = 0;

            foreach (var item in summanden)
            {
                summe += item;
            }

            return summe;
        }

        ///Wird einem Parameter mittels =-Zeichen ein Defaultwert zugewiesen wird dieser Parameter OPTIONAL und muss bei Aufruf nicht zwangs-
        ///läufig mitgegeben werden. OPTIONALE Parameter müssen am Ende der Parameter stehen.
        static int Subtrahiere(int a, int b, int c = 0, int d = 0)
        {
            return a - b - c - d;
        }

        //Das OUT-Stichwort ermöglich einer Methode mehr als einen Rückgabewert zu haben. Dabei kann die Variable direkt in der Funktions-
        ///übergabe deklariert werden
        static int AddiereUndSubtrahiere(int a, int b, out int differenz)
        {
            differenz = a - b;
            return a + b;
        }
    }
}
