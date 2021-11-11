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
    public partial class Menu2 : Persona
    {
        public Menu2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUniversitario universitario = new FrmUniversitario();
            this.Hide();
            universitario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmIngenieria ingenieria = new FrmIngenieria();
            this.Hide();
            ingenieria.Show();
        }
    }
}
