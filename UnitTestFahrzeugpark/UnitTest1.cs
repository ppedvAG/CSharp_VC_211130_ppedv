using Microsoft.VisualStudio.TestTools.UnitTesting;
//Um auf ein anderes Projekt zugreifen zu k�nnen (hier: Fahrzeugpark) muss dieses zu den Abh�ngigkeiten (Dependencies) des aktuellen
//Projekts hinzugef�gt werden. Die using-Anweisung gew�hrt dann einen verk�rzten Zugriff.
using Fahrzeugpark;

//Mittels UNIT-Tests k�nnen Klassen kleinteilig langfristig getestet werden.
namespace UnitTestFahrzeuge
{
    [TestClass]
    public class PKW_Test
    {
        //Test-Methoden werden durch den TestExplorer von VisualStudio als solche erkannt und k�nnen �ber diesen ausgef�hrt werden.
        [TestMethod]
        public void Beschleunige_PKW_ueber_MaxG()
        {
            Fahrzeugpark.PKW pkw = new Fahrzeugpark.PKW("BMW", 230, 25000, 3);

            pkw.StarteMotor();
            pkw.Beschleunige(240);

            //Jede Test-Methode ben�tigt mindestens einen Aufruf der ASSERT-Klasse, in welcher die Erfolgsbedingung des Tests �berpr�ft wird
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
