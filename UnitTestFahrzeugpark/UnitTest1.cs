using Microsoft.VisualStudio.TestTools.UnitTesting;
//Um auf ein anderes Projekt zugreifen zu können (hier: Fahrzeugpark) muss dieses zu den Abhängigkeiten (Dependencies) des aktuellen
//Projekts hinzugefügt werden. Die using-Anweisung gewährt dann einen verkürzten Zugriff.
using Fahrzeugpark;

//Mittels UNIT-Tests können Klassen kleinteilig langfristig getestet werden.
namespace UnitTestFahrzeuge
{
    [TestClass]
    public class PKW_Test
    {
        //Test-Methoden werden durch den TestExplorer von VisualStudio als solche erkannt und können über diesen ausgeführt werden.
        [TestMethod]
        public void Beschleunige_PKW_ueber_MaxG()
        {
            Fahrzeugpark.PKW pkw = new Fahrzeugpark.PKW("BMW", 230, 25000, 3);

            pkw.StarteMotor();
            pkw.Beschleunige(240);

            //Jede Test-Methode benötigt mindestens einen Aufruf der ASSERT-Klasse, in welcher die Erfolgsbedingung des Tests überprüft wird
            Assert.AreEqual(pkw.MaxGeschwindigkeit, pkw.AktGeschwindigkeit);
        }

        [TestMethod]
        public void Bremse_PKW_unter_0()
        {
            PKW pkw = new PKW("BMW", 230, 25000, 3);

            pkw.StarteMotor();
            pkw.Beschleunige(200);
            pkw.Beschleunige(-300);

            Assert.AreEqual(0, pkw.AktGeschwindigkeit);
        }
    }
}
