using System;
using System.Collections.Generic;
using System.Linq;

//DELEGATES sind Variablen, in welcher eine oder mehrere Referenzen auf Methoden gespeichert werden können
namespace Delegates
{
    //Definition eines eigenen Delegate-Datentypen. Die Signatur (Rückgabetyp, Übergabeparametertypen) definiert die Art von Methoden, welche hineingelegt werden können.
    public delegate int MeinDelegate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration einer Delegate-Variablen
            MeinDelegate delegateVariable;
            //Zuweisung der Variablen mit einer Methode (s.u.)
            delegateVariable = Addiere;
            //Aufruf der Methode über Delegate-Variable
            int erg = delegateVariable(45, 12);
            Console.WriteLine(erg);

            //Neuzuweisung des Delegates
            delegateVariable = Subtrahiere;
            Console.WriteLine(delegateVariable(45, 12));

            //per += können weitere Methoden hinzugefügt werden
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            //Alle Methoden werden nacheinander ausgefühert, aber nur der Rückgabewert der letzten Methode wird zurückgegeben
            Console.WriteLine(delegateVariable(45, 12));

            //Ausgabe aller referenzierter Methoden
            foreach (var item in delegateVariable.GetInvocationList())
            {
                Console.WriteLine(item.Method);
            }

            //per -= können Methoden aus dem Delegate gelöst werden
            delegateVariable -= Addiere;
            //Löschen aller Referenzen
            delegateVariable = null;

            //FUNC, ACTION und PREDICATE sind vordefinierte, generische Delegate-Datentypen
            Func<int, int, int> meinFunc = Addiere;

            //Übergabe einer Methode an eine andere Methode
            FühreAus(meinFunc);
            FühreAus(Addiere);

            //Beispiel-Liste
            List<string> Städteliste = new List<string>() { "München", "Berlin", "Hamburg", "Köln" };
            string gefundeneStadt;

            //Aufruf der Find()-Funktion mit Übergabe einer Methode zur Definition der inneren Logik
            gefundeneStadt = Städteliste.Find(SucheStadtMitB);
            //Übergabe der Methode als anonyme Methode
            gefundeneStadt = Städteliste.Find
                (
                    delegate (string stadt)
                    {
                        return stadt.StartsWith('B');
                    }
                );
            //Übergabe der anonymen Methode in Lambda-Schreibweise (lang und kurz)
            gefundeneStadt = Städteliste.Find((string stadt) => { return stadt.StartsWith('B'); });

            gefundeneStadt = Städteliste.Find(stadt => stadt.StartsWith('B'));

            //weiteres Lambda-Beispiel mit der OrderBy-Methode
            Städteliste = Städteliste.OrderBy(stadt => stadt[0]).ToList();
            foreach (var item in Städteliste)
            {
                Console.WriteLine(item);
            }

        }

        //Beipiel-Methode für Übergabe an Find()
        public static bool SucheStadtMitB(string stadt)
        {
            return stadt.StartsWith('B');
        }

        //Beispiel für Methode, welche einen Delegate als Übergabe erwartet
        public static void FühreAus(Func<int, int, int> mehrLogik)
        {
            mehrLogik(45, 78);
        }

        //Beispielmethoden für obige Delegate-Variablen
        public static int Addiere(int a, int b)
        {
            Console.WriteLine("Addiere");
            return a + b;
        }
        public static int Subtrahiere(int a, int b)
        {
            Console.WriteLine("Subtrahiere");
            return a - b;
        }
    }
}
