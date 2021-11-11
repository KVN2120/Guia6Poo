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
    public partial class FrmIngenieria : Frmregistro
    {
        private List<Ingenieria> Ingenierias = new List<Ingenieria>();
        private int edit_indice = -1;

        private void actualizarGrid()
        {
            dgv4.DataSource = null;
            dgv4.DataSource = Ingenierias;
        }
        private void limpiar()
        {
            txtnombre.Clear();
            txtnumerohoras.Clear();
            txttotalhoras.Clear();

        }
        int posicio;
        public FrmIngenieria()
        {
            InitializeComponent();
        }

        private void FrmIngenieria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgv4_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgv4.SelectedRows[0];
            int posicion = dgv4.Rows.IndexOf(selected);
            edit_indice = posicion;

            Ingenieria inge = Ingenierias[posicion];
            txtnombre.Text = inge.NombreProyecto;
            txtnumerohoras.Text = inge.NumeroHorasCompletas;
            txttotalhoras.Text = inge.TotalHoras;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ingenieria inge = new Ingenieria();
            inge.NombreProyecto = txtnombre.Text;
            inge.NumeroHorasCompletas = txtnumerohoras.Text;
            inge.TotalHoras = txttotalhoras.Text;

            if (edit_indice > -1)
            {
                Ingenierias[edit_indice] = inge;
                edit_indice = -1;
            }
            else
            {
                Ingenierias.Add(inge);
            }
            actualizarGrid();
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgv4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicio = dgv4.CurrentRow.Index;
            txtnombre.Text = dgv4[0, posicio].Value.ToString();
            txtnumerohoras.Text = dgv4[1, posicio].Value.ToString();
            txttotalhoras.Text = dgv4[2, posicio].Value.ToString();

            button2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nombre, numerohoras, totalhoras;

            nombre = txtnombre.Text;
            numerohoras = txtnumerohoras.Text;
            totalhoras = txttotalhoras.Text;

            dgv4[0, posicio].Value = txtnombre.Text;
            dgv4[1, posicio].Value = txtnumerohoras.Text;
            dgv4[2, posicio].Value = txttotalhoras.Text;

            limpiar();
        }


    }
}
