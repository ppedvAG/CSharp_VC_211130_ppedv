using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{    
    class Program
    {
        static void Main(string[] args)
        {
            #region Modul 06: OOP

            ////Deklarierung von Person-Variablen und Instanziierung von neuen Personenobjekten per Konstruktor
            //Person neuePerson = new Person("Anna", "Meier", new DateTime(1994, 4, 23));
            //Person neuePerson2 = new Person("Hannes", "Schmidt", new DateTime(1972, 12, 2));

            ////Lesezugriff auf Property per Getter
            //Console.WriteLine(neuePerson.Vorname);

            ////Schreibzugriff auf Property per Setter
            //neuePerson.Vorname = "Otto";
            //Console.WriteLine(neuePerson.Vorname);

            //Console.WriteLine(neuePerson.Geburtsdatum);
            //Console.WriteLine(neuePerson.AlterInJahren);

            ////Aufruf einer klasseneigenen Funktion
            //neuePerson.KorrigiereGeburtsdatumUmEinJahr();
            //neuePerson.KorrigiereGeburtsdatumUmEinJahr();
            //neuePerson.KorrigiereGeburtsdatumUmEinJahr();
            //neuePerson.KorrigiereGeburtsdatumUmEinJahr();

            //Console.WriteLine(neuePerson.AlterInJahren);

            #endregion

            #region Modul 07: Statische Member und GC

            ////Neuzuweisung der Variablen (um das Personenobjekt freizugeben und die GC demonstrieren zu können)
            //neuePerson = new Person("Anna", "Meier", new DateTime(1994, 4, 23));

            ////Aufruf der GC und Programmpause, bis alle Destruktoren beendet wurden
            //GC.Collect();
            //GC.WaitForPendingFinalizers();

            ////Aufruf eines statischen Members der Person-Klasse
            //Person.ZeigeAnzahlPersonen();

            #endregion

            #region Modul 08: Vererbung

            ////Instanziierung eines Objekts der vererbenden Klasse
            //Person chef = new Person("Anna", "Nass", new DateTime(1974, 4, 12));
            ////Instanziierung eines Objekts der abgeleiteten Klasse
            //Arbeitnehmer an = new Arbeitnehmer("Marketing", chef, "Rainer", "Zufall", new DateTime(1999, 5, 23));

            ////Aufruf von Properties und Methoden, welche aus der Mutterklasse stammen
            //Console.WriteLine(an.AlterInJahren);
            //an.KorrigiereGeburtsdatumUmEinJahr();
            //Console.WriteLine(an.AlterInJahren);

            ////Ausgabe der (überschriebenen) ToString()-Methoden
            //Console.WriteLine(chef.ToString());
            //Console.WriteLine(an);

            ////Aufruf einer Property der abgeleiteten Klasse
            //Console.WriteLine(an.Abteilung);

            ////Aufruf einer Property eines abhängigen Objekts
            //Console.WriteLine(an.Chef.AlterInJahren);

            #endregion

            #region Modul 09: Polymorphismus

            ////Deklaration einer Bsp-Variablen
            //Person person;
            ////Instanziierung eines Objekts der abgeleiteten Klasse
            //Arbeitnehmer an = new Arbeitnehmer("Anna", "Meier", new DateTime(1997, 5, 6), new Arbeitnehmer("Hugo", "Schmidt", new DateTime(1988, 4, 23), null, "CEO"), "Marketing");

            ////Zuweisung des abgeleiteten Objekts zu Variable der Mutterklasse
            //person = (Person)an;

            ////Tests des Laufzeittyps (des beinhalteten Objekts)
            //if (person.GetType() == typeof(Arbeitnehmer))
            //    Console.WriteLine("Person hat Arbeit");

            //if (person is Arbeitnehmer)
            //    Console.WriteLine("Person hat Arbeit");

            ////überschriebene Methoden werden trotzdem ausgeführt
            //Console.WriteLine(person.ToString());

            //if (person is Arbeitnehmer)
            //{
            //    //Rückcast des abgeleiteten Objekts aus Mutterklassevariablen in abgeleitete Variable
            //    Arbeitnehmer an2 = (Arbeitnehmer)person;
            //    //Alternativer Cast
            //    Arbeitnehmer an2 = person as Arbeitnehmer;
            //}

            ////Aufruf der abstrakten Methode
            //person.Essen();

            #endregion


            Arbeitnehmer an = new Arbeitnehmer("Marketing", new Person("Otto", "Meier", new DateTime(2001, 4, 3)), "Anna", "Müller", new DateTime(2003, 4, 30));

            ILohn lohnerhaltendesObjekt = an;

            an.Auszahlung();
            lohnerhaltendesObjekt.Auszahlung();

            Gehaltserhöhung(an);
        }

        public static void Gehaltserhöhung(ILohn lohn)
        {
            lohn.Gehalt += 100;

            if(lohn is Arbeitnehmer)
            {
                Arbeitnehmer an = lohn as Arbeitnehmer;
                an.Essen();
            }
        }
    }
}