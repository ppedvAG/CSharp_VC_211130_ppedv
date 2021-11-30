//Mittels der USING-Anweisungen kann ein vereinfachter Zugriff auf Programm-Externe Klassen ermöglicht werden. Es muss nun nicht mehr der
///vollständige Pfad angegeben werden, sondern es reicht der Klassenbezeichner
using System;

//NAMESPACE: Die Umgebung unseres aktuellen Programms: Alles innerhalb des Namespaces gehört zu dem Programm
namespace HelloWorld
{
    //Die PROGRAM-Klasse beinhaltet den Einstiegspunkt des Programms und muss in jedem C#-Programm vorhanden sein
    class Program
    {
        //Die MAIN()-Methode ist der Einstiegspunkt jedes C#-Programms: Hier beginnt das Programm IMMER
        static void Main(string[] args)
        {
            //Ausgabe eines String-Literals (Literale sind 'ausgeschriebene' Werte, im Gegensatz zu Werten die in einer Variablen stecken)
            Console.WriteLine("Hello World!");

            //Deklaration einer Integer-Variable 
            int Alter;
            //Initialisierung der Integer-Variablen
            Alter = 32;
            //Gleichzeitige Deklaration und Initialisierung einer String-Variablen
            string Stadt = "Berlin";
            //Ausgabe der Variablen
            Console.WriteLine(Alter);
            Console.WriteLine(Stadt);
            //Deklaration und Initialisierung einer Integer-Variablen mithilfe einer anderen Integer-Variablen
            int DoppeltesAlter = Alter * 2;
            Console.WriteLine(DoppeltesAlter);
            //Int-Berechnung innerhalb String-Ausgabe
            Console.WriteLine(Alter + DoppeltesAlter);

            //Beispiel-Char-Variable
            char Textzeichen = 'A';
            //Beispiel-Double-Variable
            double Kosten = 78.123;
            Console.WriteLine(Kosten);


            ///Einfügen dynamischer Inhalte in Strings
            //'traditionell' über Stringverknüpfung (+-Operator)
            string Satz = "Ich bin " + Alter + " Jahre alt und wohne in " + Stadt + ".";
            Console.WriteLine(Satz);
            Console.WriteLine("Ich bin " + Alter + " Jahre alt und wohne in " + Stadt + ".");
            //$-Operator (Variablen werde direkt in {}-Klammern geschrieben)
            Satz = $"Ich bin {Alter} Jahre alt und wohne in {Stadt}.";
            Console.WriteLine(Satz);
            Console.WriteLine($"Ich bin {Alter} Jahre alt und wohne in {Stadt}.");
            //Index (Variablen werden durch Index-Platzhalter vertreten und später definiert)
            Console.WriteLine("Ich bin {0} Jahre alt und wohne in {1}.", Alter, Stadt);

            //Ausgabe einer Berchnung in Strings
            int a = 45;
            int b = 12;
            Console.WriteLine($"{a} + {b} = {a + b}");

            //String-Formatierung mittels Escape-Sequenzen
            string bsp = "Dies ist ein \tTabulator und dies ein \nZeilenumbruch.";
            Console.WriteLine(bsp);
            //Bsp für Pfadausgabe mittels Escape-Sequenzen
            string path = "C:\\Programme\\Programm.exe";
            Console.WriteLine(path);

            //String-Formatierung mittels VerbaTim-String (Einleitung mittels @ / Escape-Sequenzen sind nicht möglich, dynamische Inhalte mittels $ schon)
            string verbatim = @$"Dies ist ein    Tabulator und dies ein 
Zeilenumbruch {Stadt}";
            Console.WriteLine(verbatim);
            //Bsp für Pfadausgabe in Verbatim-String
            path = @"C:\Programme\Programm.exe";


            //Eingabe eines Strings durch den Benutzer und Abspeichern in einer String-Variablen
            Console.WriteLine("Bitte gib deinen Namen an:");
            string eingabe = Console.ReadLine();
            //Ausgabe
            Console.WriteLine($"Dein Name ist also {eingabe}.");


            //Eingabe eines Strings, Umwandlung in einen Integer (Parse()-Funktion) und Abspeichern in einer Integer-Variablen
            Console.WriteLine("Bitte gib deine Lieblingszahl ein:");
            string zahlAlsString = Console.ReadLine();
            int zahl = int.Parse(zahlAlsString);
            zahl = zahl * 2;
            //Ausgabe
            Console.WriteLine(zahl);

            //Benutzereingabe (Tastendruck) hier als Programmpause, bis Benutzer einer Taste drückt
            Console.ReadKey();

            //Umwandlung durch Convert.To[]()-Funktion
            zahl = Convert.ToInt32(78.45);

            //Bsp für numerische Umwandlung (impliziet, da kein Datenverlust)
            int intZahl = 78;
            double doubleZahl = intZahl;

            //Bsp für numerische Umwandlung mittels Cast (expliziet, da möglicherweise Datenverlust)
            doubleZahl = 45.75;
            intZahl = (int)doubleZahl;

            //Bsp für Teilung durch 0 von Gleitkommazahlen
            double zero = 0.0;
            double z = 2 / zero;
            Console.WriteLine(z);
        }
    }
}
