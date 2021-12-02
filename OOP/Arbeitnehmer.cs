using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //Arbeitnehmer erbt mittels des :-Zeichens von der Person-Klasse und übernimmt somit alle Eigenschaften und Methoden von dieser.
    class Arbeitnehmer : Person
    {
        //Zusätzliche Arbeitnehmer-eigene Eigenschaften
        public string Abteilung { get; set; }
        public Person Chef { get; set; }

        //Arbeitnehmer-Konstruktor, welcher per BASE-Stichwort den Konstruktor der Personklasse aufruft. Dieser erstellt dann eine Person, gibt diese
        ///an diesen Konstruktor zurück, welcher dann die zusätzlichen Eigenschaften einfügt
        public Arbeitnehmer(string abteilung, Person chef, string vorname, string nachname, DateTime geburtsdatum) : base(vorname, nachname, geburtsdatum)
        {
            this.Abteilung = abteilung;
            this.Chef = chef;
        }

        //Mittels OVERRIDE können Methoden der Mutterklassen, welche mit VIRTUAL markiert sind, überschrieben werden. Bei Aufruf wird die neue Methode ausgeführt.
        //Mittels BASE kann ein Rückbezug zur nächst-höheren Klasse hergestellt werden.
        //Mit SEALED kann eine Überschreibung durch Kindklassen verindert werden.
        public sealed override string ToString()
        {
            return base.ToString() + $" Der Chef heißt {this.Chef} und arbeitet in der Abteilung {this.Abteilung}.";
        }

        //Durch Mutterklasse erzwungene (weil dort abstrakte) Methode
        public override void Essen()
        {
            Console.WriteLine("Kantinenessen");
        }
    }
}
