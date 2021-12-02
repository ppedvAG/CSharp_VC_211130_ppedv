using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    //Schiff erbt von der Fahrzeug-Klasse und übernimmt deren Member
    public class Schiff : Fahrzeug, IBeladbar
    {
        //Klasseneigener Enum
        public enum SchiffsTreibstoff { Diesel = 0, Dampf, Wind, Muskelkraft }

        //Klasseneigene Property
        public SchiffsTreibstoff Treibstoff { get; set; }

        //Konstruktor mit Bezug auf den Konstruktor der Mutterklasse (base)
        public Schiff(string name, int maxG, double preis, SchiffsTreibstoff treibstoff) : base(name, maxG, preis)
        {
            this.Treibstoff = treibstoff;
        }

        //Überxchreibung der Info()-Methode mit Bezug auf die Methode der Mutterklasse (base)
        public override string Info()
        {
            if (this.Ladung == null)
                return "Das Schiff " + base.Info() + $" Es fährt mit {this.Treibstoff}.";
            else
                return "Das Schiff " + base.Info() + $" Es fährt mit {this.Treibstoff} und transportiert '{this.Ladung.Name}'.";
        }

        //Durch Mutterklasse verlangter Member (da dort als abstract gesetzt)
        public override void Hupen()
        {
            Console.WriteLine($"{this.Name}: 'Tröööt'");
        }

        //Durch IBeladbar verlangte Property
        public Fahrzeug Ladung { get; set; }

        //Durch IBeladbar verlangte Methoden
        public void Belade(Fahrzeug fz)
        {
            //Prüfung auf Gleichheit der Fahrzeuge
            if (this.Equals(fz))
            {
                Console.WriteLine("Das Fahrzeug kann sich nicht selber transportieren.");
            }
            //Prüfung, ob der Ladeplatz leer ist
            else if (this.Ladung == null)
            {
                //Übernehmen der Ladung
                this.Ladung = fz;
                //Erfolgsmeldung
                Console.WriteLine($"Ladevorgang von '{fz.Name}' auf '{this.Name}' erfolgreich.");
            }
            //Fehlermeldung
            else
                Console.WriteLine($"Ladeplatz auf '{this.Name}' bereits durch '{this.Ladung.Name}' belegt.");
        }

        public Fahrzeug Entlade()
        {
            //Prüfung, ob Ladung vorhanden ist
            if (this.Ladung != null)
            {
                //Zwischenspeichern zur Ausgabe
                Fahrzeug fz = this.Ladung;
                //Löschung der Ladung
                this.Ladung = null;
                //Erfolgsmeldung
                Console.WriteLine($"Entladevorgang von '{fz.Name}' erfolgreich.");
                return fz;
            }
            //Fehlermeldung
            else
                Console.WriteLine($"'{this.Name} hat keine Ladung geladen.");
            //Rückgabe von null, falls kein Fahrzeug geladen ist
            return null;
        }
    }
}
