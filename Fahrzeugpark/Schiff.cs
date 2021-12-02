using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    //Schiff erbt von der Fahrzeug-Klasse und übernimmt deren Member
    public class Schiff : Fahrzeug
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
            return "Das Schiff " + base.Info() + $" Es fährt mit {this.Treibstoff}.";
        }

        //Durch Mutterklasse verlangter Member (da dort als abstract gesetzt)
        public override void Hupen()
        {
            Console.WriteLine($"{this.Name}: 'Tröööt'");
        }
    }
}
