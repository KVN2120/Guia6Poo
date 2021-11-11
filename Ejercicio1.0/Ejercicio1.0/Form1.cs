using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insertar FormInsertar = new Insertar();
            FormInsertar.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar FormConsultar = new Consultar();
            FormConsultar.ShowDialog();
        }
    }
}
