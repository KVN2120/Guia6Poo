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
    public partial class FrmEstudiante : Frmregistro
    {
        private List<Estudiante> Estudiantes = new List<Estudiante>();
        private int edit_indice = -1;

        private void actualizarGrid()
        {
            dgv1.DataSource = null;
            dgv1.DataSource = Estudiantes;
        }
        private void limpiar()
        {
            txtcarnet1.Clear();
            txtniveldeestudio.Clear();
        }
        int pos;
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void FrmEstudiante_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtniveldeestudio_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgv1.SelectedRows[0];
            int posicion = dgv1.Rows.IndexOf(selected);
            edit_indice = posicion;

            Estudiante estu = Estudiantes[posicion];
            txtcarnet1.Text = estu.NumeroCarnet;
            txtniveldeestudio.Text = estu.NivelEstudios;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Estudiante estu = new Estudiante();
            estu.NumeroCarnet = txtcarnet1.Text;
            estu.NivelEstudios = txtniveldeestudio.Text;
            

            if (edit_indice > -1)
            {
               Estudiantes[edit_indice] = estu;
                edit_indice = -1;
            }
            else
            {
                Estudiantes.Add(estu);
            }
            actualizarGrid();
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = dgv1.CurrentRow.Index;
            txtcarnet1.Text = dgv1[0, pos].Value.ToString();
            txtniveldeestudio.Text = dgv1[1, pos].Value.ToString();
            button2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string numerocarnet, niveldeestudio;

            numerocarnet = txtcarnet1.Text;
            niveldeestudio = txtniveldeestudio.Text;

            dgv1[0, pos].Value = txtcarnet1.Text;
            dgv1[1, pos].Value = txtniveldeestudio.Text;

            limpiar();
        }

    }
}
