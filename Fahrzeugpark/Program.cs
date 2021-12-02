using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ändern des durch Console verwendeten Zeichensatzes auf Unicode (damit das €-Zeichen angezeigt werden kann)
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            #region Lab 06: Fahrzeug-Klasse

            ////Deklaration einer Fahrzeug-Variablen und Initialisierung mittels einer Fahrzeug-Instanz
            //Fahrzeug fz1 = new Fahrzeug("Mercedes", 190, 23000);
            ////Ausführen der Info()-Methode des Fahrzeugs und Ausgabe in der Konsole
            //Console.WriteLine(fz1.Info() + "\n");

            ////Diverse Methodenausführungen
            //fz1.StarteMotor();
            //fz1.Beschleunige(120);
            //Console.WriteLine(fz1.Info() + "\n");

            //fz1.Beschleunige(300);
            //Console.WriteLine(fz1.Info() + "\n");

            //fz1.StoppeMotor();
            //Console.WriteLine(fz1.Info() + "\n");

            //fz1.Beschleunige(-500);
            //fz1.StoppeMotor();
            //Console.WriteLine(fz1.Info() + "\n");

            #endregion

            #region Lab 07: GC und statische Member

            ////Generierung von div. Objekten (zur Überschwemmung des RAM)
            //Fahrzeug fz1 = new Fahrzeug("BMW", 230, 25999.99);
            //for (int i = 0; i < 1000; i++)
            //{
            //    fz1 = new Fahrzeug("BMW", 230, 25999.99);
            //}

            ////Bsp-Aufruf der GarbageCollection
            //GC.Collect();
            ////Abwarten der Finalizer-Ausführungen (der Objekte)
            //GC.WaitForPendingFinalizers();

            ////Aufruf der statischen Methode
            //Console.WriteLine(Fahrzeug.ZeigeAnzahlFahrzeuge());

            #endregion

            #region Lab 08: Vererbung

            ////Instanziierung verschiedener Fahrzeuge
            //PKW pkw1 = new PKW("Mercedes", 210, 23000, 5);
            //Schiff schiff1 = new Schiff("Titanic", 40, 25000000, Schiff.SchiffsTreibstoff.Dampf);
            //Flugzeug flugzeug1 = new Flugzeug("Boing", 350, 90000000, 9800);

            ////Ausgabe der verschiedenen Info()-Methoden
            //Console.WriteLine(pkw1.Info());
            //Console.WriteLine(schiff1.Info());
            //Console.WriteLine(flugzeug1.Info());

            #endregion

            #region Lab 09: Polymorphismus

            //Arraydeklarierung
            Fahrzeug[] fahrzeuge = new Fahrzeug[10];

            //Schleife über das Array zur Befüllung
            for (int i = 0; i < fahrzeuge.Length; i++)
            {
                //Aufruf der Zufallsmethode aus der Fahrzeug-Klasse
                fahrzeuge[i] = Fahrzeug.GeneriereFahrzeug($"_{i}");
            }

            //Deklarierung/Initialisierung der Zählvariablen
            int pkws = 0, schiffe = 0, flugzeuge = 0;

            //Schleife über das Array zur Identifizierung der Objekttypen
            foreach (Fahrzeug item in fahrzeuge)
            {
                //Ausgabe der ToString()-Methoden
                Console.WriteLine(item);
                //Prüfung des Objektstyps und Hochzählen der entsprechenden Variablen
                if (item == null) Console.WriteLine("Kein Objekt vorhanden");
                else if (item is PKW) pkws++;
                else if (item is Schiff) schiffe++;
                else flugzeuge++;
            }

            //Ausgabe
            Console.WriteLine($"Es wurden {pkws} PKW(s), {flugzeuge} Flugzeug(e) und {schiffe} Schiff(e) produziert.");
            //Ausführung der abstrakten Methode
            fahrzeuge[2].Hupen();

            #endregion
        }
    }
}
