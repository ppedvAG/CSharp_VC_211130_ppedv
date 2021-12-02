using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //KLASSEN sind Vorlagen für Objekte. Sie bestimmen Eigenschaften und Funktionen dieser.
    //ABSTRACT definiert eine Klasse als abstrakt. D.h. von dieser Klasse können keine Objekte mehr instanziiert werden, sie dient nur noch als Mutterklasse
    public abstract class Person //zur Verwendung vgl. Program.cs
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

            AnzahlPersonen++;
        }

        //Es können mehrere Konstruktoren definiert werden, welche unterschiedliche Übergabeparameter haben (Überladung). Ein Konstruktor, der keine
        //Übergabeparameter hat, wird als Basiskonstruktor bezeichnet
        //public Person()
        //{

        //}
        #endregion

        #region Methoden

        //MEMBERMETHODEN sind Funktionen, welche jedes Objekt einer Klasse besitzt und speziell dieses Objekt manipuliert
        public void KorrigiereGeburtsdatumUmEinJahr()
        {
            this.Geburtsdatum = Geburtsdatum.AddYears(1);
        }

        #endregion

        #region Statische Member

        //STATISCHE Variablen und Methoden hängen an der Klasse selbst und nicht an instanziierten Objekten. Sie existieren demnach unabhängig von der Anzahl
        ///Objekte genau einmal. Der Aufruf erfolgt über den Klassenbezeichner.
        public static int AnzahlPersonen { get; set; } = 0;

        public static string ZeigeAnzahlPersonen()
        {
            return $"Es gibt {AnzahlPersonen} Personen.";
        }

        #endregion

        #region Destruktor

        //Der DESTRUKTOR wird von der GarbageCollection aufgerufen, wenn das Objekt nicht
        //mehr referenziert ist. Hier können Aktionen definiert werden,
        //welche zusätzlich zur 'Zerstörung' erfolgen sollen.
        ~Person()
        {
            Console.WriteLine($"{this.Vorname} {this.Nachname} wurde zerstört.");
            AnzahlPersonen--;
        }

        #endregion

        //Mittels OVERRIDE können Methoden der Mutterklassen, welche mit VIRTUAL markiert sind, überschrieben werden. Bei Aufruf wird die neue Methode ausgeführt.
        public override string ToString()
        {
            return $"{this.Vorname} {this.Nachname} ist {this.AlterInJahren} Jahre alt";
        }

        //Abstrakte Methoden dürfen nur in abstrakten Klassen existieren und definieren nur
        ///eine Signatur. Die erbenden Klassen werden gezwungen eine Implementierung vorzunehmen
        public abstract void Essen();
    }
}