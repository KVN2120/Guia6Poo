using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Universitario
    {
        private string nombreu;
        private string carrera;
        private string materiasinscritas;
        private int nota1;
        private int nota2;
        private int nota3;

        private string cum;

        public string NombreU
        {
            get { return nombreu; }
            set { nombreu = value; }
        }
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public string MateriasInscritas
        {
            get { return materiasinscritas; }
            set { materiasinscritas = value; }
        }
        public int Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }
        public int Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }
        public int Nota3
        {
            get { return nota3; }
            set { nota3 = value; }
        }

        public string Cum
        {
            get { return cum; }
            set { cum = value; }
        }
    }
}
