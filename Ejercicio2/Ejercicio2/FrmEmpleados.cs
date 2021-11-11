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
    public partial class FrmEmpleados : Frmregistro
    {
        private List<Empleado> Empleados = new List<Empleado>();
        private int edit_indice = -1;

        private void actualizarGrid()
        {
            dgv2.DataSource = null;
            dgv2.DataSource = Empleados;
        }
        private void limpiar()
        {
            txtnombre1.Clear();
            txtapellido.Clear();
            txtcodigo.Clear();

        }
        int posi;
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgv2_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgv2.SelectedRows[0];
            int posicion = dgv2.Rows.IndexOf(selected);
            edit_indice = posicion;

            Empleado emple= Empleados[posicion];
            txtnombre1.Text = emple.Nombre;
            txtapellido.Text = emple.Apellido;
            txtcodigo.Text = emple.Codigo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Empleado emple = new Empleado();
            emple.Nombre = txtnombre1.Text;
            emple.Apellido = txtapellido.Text;
            emple.Codigo = txtcodigo.Text;
            if (edit_indice > -1)
            {
                Empleados[edit_indice] = emple;
                edit_indice = -1;
            }
            else
            {
                Empleados.Add(emple);
            }
            actualizarGrid();
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posi = dgv2.CurrentRow.Index;
            txtnombre1.Text = dgv2[0, posi].Value.ToString();
            txtapellido.Text = dgv2[1, posi].Value.ToString();
            txtcodigo.Text = dgv2[2, posi].Value.ToString();
            button2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nombre, apellido, codigo;

            nombre = txtnombre1.Text;
            apellido = txtapellido.Text;
            codigo = txtcodigo.Text;

            dgv2[0, posi].Value = txtnombre1.Text;
            dgv2[1, posi].Value = txtapellido.Text;
            dgv2[2, posi].Value = txtcodigo.Text;

            limpiar();
        }

        }
    }

