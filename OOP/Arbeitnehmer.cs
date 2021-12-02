using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //Arbeitnehmer erbt mittels des :-Zeichens von der Person-Klasse und übernimmt somit alle Eigenschaften und Methoden von dieser.
    class Arbeitnehmer : Person, ILohn, ICloneable
    {
        //Zusätzliche Arbeitnehmer-eigene Eigenschaften
        public string Abteilung { get; set; }
        public Person Chef { get; set; }

        //Durch ILohn verlangte Eigenschaft
        public int Gehalt { get; set; } = 3500;

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
                
        //Ducrh ILohn verlangte Methode
        public void Auszahlung()
        {
            Console.WriteLine($"{this.Vorname} {this.Nachname} hat {this.Gehalt}€ von {this.Chef.Vorname} {this.Chef.Nachname} bekommen.");
        }

        //Durch IClonable verlangte Methode (Bsp für .NET-eigenes Interface)
        ///Diese Methode erlaubt die Erstellung einer Kopie dieses Objekts
        public object Clone()
        {
            //Durch .MemberwiseClone() werden alle Wertetypen des Originalobjekts kopiert
            Arbeitnehmer an = (Arbeitnehmer)this.MemberwiseClone();
            //Referenzen müssen manuell neu zugewiesen werden oder ebenfalls über IClonable verfügen und durch .Clone() kopiert werden
            an.Chef = this.Chef;
            return an;
        }

        //Alternativ zu IClonable kann ein Kopierkonstruktor zur Dublizierung verwendet werden. Hier werden die Werte und Referenzen koiert und übertragen
        public Arbeitnehmer(Arbeitnehmer alterArbeitnehmer)
        {
            this.Vorname = alterArbeitnehmer.Vorname;
            this.Geburtsdatum = alterArbeitnehmer.Geburtsdatum;
            //...
        }
    }
}
