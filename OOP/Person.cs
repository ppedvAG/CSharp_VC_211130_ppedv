using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //KLASSEN sind Vorlagen für Objekte. Sie bestimmen Eigenschaften und Funktionen dieser.
    public class Person //zur Verwendung vgl. Program.cs
    {
        #region Felder und Eigenschaften
        //FELDER (Membervariablen) sind die Variablen einzelner Objekte, welche die Zustände dieser Objekte definieren
        private string vorname = "Hugo";
        //EIGENSCHAFTEN (Properties) definieren mittels Getter/Setter den Lese-/Schreibzugriff für jeweils ein Feld.
        ///In den Eigenschaften können bestimmte Bedingungen für das Lesen und Schreiben der Felder gesetzt werden, sowie der Zugriff
        ///für Lesen und Schreiben einzeln angepasst werden
        //Snippet: propfull
        public string Vorname
        {
            get { return vorname; }
            set
            {
                //Das Schlüsselwort VALUE beschreibt in einer Set-Methode den übergebenen Wert
                if (value.Length > 0)
                    vorname = value;
            }
        }

        //Wird in einer Eigenschaft keine Spezifizierung angegeben, generiert das Programm das entsprechende Feld unsichtbar im Hintergrund
        //Snippet: prop
        public string Nachname { get; set; }

        //Property, welche einen komplexen Datentypen abbildet
        public DateTime Geburtsdatum { get; set; }
        //Read-only Property mit Rückbezug auf andere Property
        public int AlterInJahren
        {
            get { return ((DateTime.Now - this.Geburtsdatum).Days / 365); }
        }
        #endregion

        #region Konstruktor
        //KONSTRUKTOREN sind spezielle Methoden, welche ein neues Objekt instanziiert und den Anfangszustand festlegt. Sie definieren sich
        ///durch den Namen (derselbe, wie die Klasse) und den nicht vorhandenen Rückgabetyp (nicht mal void)
        public Person(string vorname, string nachname, DateTime geburtsdatum)
        {
            this.Vorname = vorname;
            this.Nachname = nachname;
            this.Geburtsdatum = geburtsdatum;
        }

        //Es können mehrere Konstruktoren definiert werden, welche unterschiedliche Übergabeparameter haben (Überladung). Ein Konstruktor, der keine
        //Übergabeparameter hat, wird als Basiskonstruktor bezeichnet
        public Person()
        {

        }
        #endregion

        #region Methoden

        //MEMBERMETHODEN sind Funktionen, welche jedes Objekt einer Klasse besitzt und speziell dieses Objekt manipuliert
        public void Altern()
        {
            this.Geburtsdatum = Geburtsdatum.AddYears(1);
        }

        #endregion

    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Modul 06: OOP
            //Deklarierung von Person-Variablen und Instanziierung von neuen Personenobjekten per Konstruktor
            Person neuePerson = new Person("Anna", "Meier", new DateTime(1994, 4, 23));
            Person neuePerson2 = new Person("Hannes", "Schmidt", new DateTime(1972, 12, 2));

            //Lesezugriff auf Property per Getter
            Console.WriteLine(neuePerson.Vorname);

            //Schreibzugriff auf Property per Setter
            neuePerson.Vorname = "Otto";
            Console.WriteLine(neuePerson.Vorname);

            Console.WriteLine(neuePerson.Geburtsdatum);
            Console.WriteLine(neuePerson.AlterInJahren);

            //Aufruf einer klasseneigenen Funktion
            neuePerson.Altern();
            neuePerson.Altern();
            neuePerson.Altern();
            neuePerson.Altern();

            Console.WriteLine(neuePerson.AlterInJahren);
            #endregion
        }
    }
}