using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    public class Fahrzeug
    {
        #region Lab 06: Properties, Methoden, Konstruktor

        //Properties
        public string Name { get; set; }
        public int MaxGeschwindigkeit { get; set; }
        public int AktGeschwindigkeit { get; set; }
        public double Preis { get; set; }
        public bool MotorLäuft { get; set; }

        //Konstruktor mit Übergabeparametern und Standartwerten
        public Fahrzeug(string name, int maxG, double preis)
        {
            this.Name = name;
            this.MaxGeschwindigkeit = maxG;
            this.Preis = preis;
            this.AktGeschwindigkeit = 0;
            this.MotorLäuft = false;
        }

        //Methode zur Ausgabe von Objektinformationen
        public string Info()
        {
            if (this.MotorLäuft)
                return $"{this.Name} kostet {this.Preis}€ und fährt momentan mit {this.AktGeschwindigkeit} von maximal {this.MaxGeschwindigkeit}km/h.";
            else
                return $"{this.Name} kostet {this.Preis}€ und könnte maximal {this.MaxGeschwindigkeit}km/h fahren.";
        }

        //Methode zum Starten des Motors
        public void StarteMotor()
        {
            if (this.MotorLäuft)
                Console.WriteLine($"Der Motor von {this.Name} läuft bereits.");
            else
            {
                this.MotorLäuft = true;
                Console.WriteLine($"Der Motor von {this.Name} wurde gestartet.");
            }
        }

        //Methode zum Stoppen des Motors
        public void StoppeMotor()
        {
            if (!this.MotorLäuft)
                Console.WriteLine($"Der Motor von {this.Name} ist bereits gestoppt");
            else if (this.AktGeschwindigkeit > 0)
                Console.WriteLine($"Der Motor kann nicht gestoppt werden, da sich {this.Name} noch bewegt");
            else
            {
                this.MotorLäuft = false;
                Console.WriteLine($"Der Motor von {this.Name} wurde gestoppt.");
            }
        }

        //Methode zum Beschleunigen und Bremsen
        public void Beschleunige(int a)
        {
            if (this.MotorLäuft)
            {
                if (this.AktGeschwindigkeit + a > this.MaxGeschwindigkeit)
                    this.AktGeschwindigkeit = this.MaxGeschwindigkeit;
                else if (this.AktGeschwindigkeit + a < 0)
                    this.AktGeschwindigkeit = 0;
                else
                    this.AktGeschwindigkeit += a;

                Console.WriteLine($"{this.Name} bewegt sich jetzt mit {this.AktGeschwindigkeit}km/h");
            }
        }

        #endregion
    }
}
