using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Classes
{
    class Dog : Interface
    {
        AnimalData perro;
        string idioma = "Guau";

        public string Talk()
        {
            return idioma;
        }
    }
}
