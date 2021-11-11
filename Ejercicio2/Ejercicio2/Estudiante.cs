using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Estudiante
    {
        private string numerocarnet;
        private string nivelestudios;

        public string NumeroCarnet
        {
            get { return numerocarnet; }
            set { numerocarnet = value; }
        }
        public string NivelEstudios
        {
            get { return nivelestudios; }
            set { nivelestudios = value; }
        }
    }
}
