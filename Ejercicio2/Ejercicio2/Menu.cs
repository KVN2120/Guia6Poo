using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Menu : Persona
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            FrmEmpleados empleado = new FrmEmpleados();
            this.Hide();
            empleado.Show();
        }

        private void btnestudiante_Click(object sender, EventArgs e)
        {
            Menu2 menu2 = new Menu2();
            this.Hide();
            menu2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUniversitario universitario = new FrmUniversitario();
            this.Hide();
            universitario.Show();
        }
    }
}
