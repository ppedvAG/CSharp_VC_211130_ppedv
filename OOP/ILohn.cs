using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    interface ILohn
    {
        int Gehalt { get; set; }

        void Auszahlung();
    }
}
