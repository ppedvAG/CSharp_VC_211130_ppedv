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
            neuePerson.KorrigiereGeburtsdatumUmEinJahr();
            neuePerson.KorrigiereGeburtsdatumUmEinJahr();
            neuePerson.KorrigiereGeburtsdatumUmEinJahr();
            neuePerson.KorrigiereGeburtsdatumUmEinJahr();

            Console.WriteLine(neuePerson.AlterInJahren);
            
            #endregion

            #region Modul 07: Statische Member und GC
               
            //Neuzuweisung der Variablen (um das Personenobjekt freizugeben und die GC demonstrieren zu können)
            neuePerson = new Person("Anna", "Meier", new DateTime(1994, 4, 23));
                       
            //Aufruf der GC und Programmpause, bis alle Destruktoren beendet wurden
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //Aufruf eines statischen Members der Person-Klasse
            Person.ZeigeAnzahlPersonen();

            #endregion
        }
    }
}