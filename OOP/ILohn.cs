using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //Ein INTERFACE zwingt die implementierenden Klassen bestimmte Methoden und Eigenschaften zu implementieren, so dass diesbezüglich 
    ///eine Typsicherheit besteht. Dieses Interface fordert die Implementierung einer Methode und einer Eigenschaft und ermöglicht
    ///einer Klasse 'ein Gehalt zu beziehen'.
    interface ILohn
    {
        //In einem Interface sind idR keine Zugriffsmodifier erlaubt
        int Gehalt { get; set; }

        //Es werden (wie bei abstarkten Methoden) idR nur die Methodenköpfe geschrieben. Der Rest wird in den implementierenden Klassen hinzugefügt
        void Auszahlung();
    }
}
