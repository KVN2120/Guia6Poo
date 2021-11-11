using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Ingenieria
    {
        private string nombreproyecto;
        private string totaldehoras;
        private string numerodehorascompletas;

        public string NombreProyecto
        {
            get { return nombreproyecto; }
            set { nombreproyecto = value; }
        }
        public string TotalHoras
        {
            get { return totaldehoras; }
            set { totaldehoras = value; }
        }
        public string NumeroHorasCompletas
        {
            get { return numerodehorascompletas; }
            set { numerodehorascompletas = value; }
        }
    }
}
