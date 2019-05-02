using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Classes
{
    class Cat : Interface
    {
        AnimalData gato;
        string idioma = "Miau";

        public string Talk()
        {
            return idioma;
        }

        public void maullar(sound suena)
        {
            suena.Sonido();
        }
    }
}
