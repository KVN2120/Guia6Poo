using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Empleado
    {
        private string nombre;
        private string apellido;
        private string codigo;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
