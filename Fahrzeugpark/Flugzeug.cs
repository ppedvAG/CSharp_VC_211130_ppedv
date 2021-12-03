using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    //vgl. Schiff
    public class Flugzeug : Fahrzeug, IEnumerable
    {
        //Bsp-Property für IEnumerable und Indexer
        public List<string> Passagierliste { get; set; } = new List<string>() { "Hanna", "Anna", "Mario", "Olaf" };

        //Indexerproperties werden über den Variablenbezeichner und eine Indexübegabe aufgerufen (wie bei Arrays und Listen)
        public string this[int index]
        {
            get { return this.Passagierliste[index]; }
            set { this.Passagierliste[index] = value; }
        }

        public int MaxFlughöhe { get; set; }

        public Flugzeug(string name, int maxG, double preis, int maxFH) : base(name, maxG, preis)
        {
            this.MaxFlughöhe = maxFH;
        }

        public override string Info()
        {
            return "Das Flugzeug " + base.Info() + $" Es kann bis auf {this.MaxFlughöhe}m aufsteigen.";
        }

        public override void Hupen()
        {
            Console.WriteLine($"{this.Name}: 'Biep Biep'");
        }

        //IEnumerable erlaubt die Verwendung des Objekts durch die foreach-Schleife, welche die GetEnumerator()-Methode aufruft
        public IEnumerator GetEnumerator()
        {
            foreach (var passagier in this.Passagierliste)
            {
                //YIELD RETURN gibt in jedem Schleifendurchlauf ein Element zurück
                yield return passagier;
            }
        }
    }

}
