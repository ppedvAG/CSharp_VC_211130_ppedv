using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Arbeitnehmer : Person
    {
        public string Abteilung { get; set; }
        public Person Chef { get; set; }

        public Arbeitnehmer(string abteilung, Person chef, string vorname, string nachname, DateTime geburtsdatum) : base(vorname, nachname, geburtsdatum)
        {
            this.Abteilung = abteilung;
            this.Chef = chef;
        }

        public override string ToString()
        {
            return base.ToString() + $" Der Chef heißt {this.Chef} und arbeitet in der Abteilung {this.Abteilung}.";
        }
    }
}
