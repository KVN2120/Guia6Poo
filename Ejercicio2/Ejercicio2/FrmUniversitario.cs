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
    public partial class FrmUniversitario : Frmregistro
    {
        private List<Universitario> Universitarios = new List<Universitario>();
        private int edit_indice = -1;

        private void actualizarGrid()
        {
            dgv3.DataSource = null;
            dgv3.DataSource = Universitarios;
        }
        private void limpiar()
        {
            txtnombreu.Clear();
            txtcarrera.Clear();
            txtmaterias.Clear();
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtcum.Clear();

        }
        
        int posic;
        public FrmUniversitario()
        {
            InitializeComponent();
        }

        private void FrmUniversitario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgv3_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgv3.SelectedRows[0];
            int posicion = dgv3.Rows.IndexOf(selected);
            edit_indice = posicion;

            Universitario univer = Universitarios[posicion];
            txtnombreu.Text = univer.NombreU;
            txtcarrera.Text = univer.Carrera;
            txtmaterias.Text = univer.MateriasInscritas;
            txtnota1.Text=Convert.ToString(univer.Nota1);
            txtnota2.Text=Convert.ToString(univer.Nota2);
            txtnota3.Text = Convert.ToString(univer.Nota3);
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Universitario univer = new Universitario();
            univer.NombreU = txtnombreu.Text;
            univer.Carrera = txtcarrera.Text;
            univer.MateriasInscritas = txtmaterias.Text;
            univer.Nota1 = int.Parse(txtnota1.Text);
            univer.Nota2 = int.Parse(txtnota2.Text);
            univer.Nota3 = int.Parse(txtnota3.Text);
            univer.Cum = txtcum.Text;


            if (edit_indice > -1)
            {
                Universitarios[edit_indice] = univer;
                edit_indice = -1;
            }
            else
            {
                Universitarios.Add(univer);
            }
            actualizarGrid();
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgv3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posic = dgv3.CurrentRow.Index;
            txtnombreu.Text = dgv3[0, posic].Value.ToString();
            txtcarrera.Text = dgv3[1, posic].Value.ToString();
            txtmaterias.Text = dgv3[2, posic].Value.ToString();
            txtnota1.Text = dgv3[4, posic].Value.ToString();
            txtnota2.Text = dgv3[5, posic].Value.ToString();
            txtnota3.Text = dgv3[6, posic].Value.ToString();
            txtcum.Text = dgv3[7, posic].Value.ToString();

            button2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nombreu, carrera, materias, cum;
            int nota1, nota2, nota3;

            nombreu = txtnombreu.Text;
            carrera = txtcarrera.Text;
            materias = txtmaterias.Text;
            nota1 = int.Parse(txtnota1.Text);
            nota2 = int.Parse(txtnota2.Text);
            nota3 = int.Parse(txtnota3.Text);

            dgv3[0, posic].Value = txtnombreu.Text;
            dgv3[1, posic].Value = txtcarrera.Text;
            dgv3[2, posic].Value = txtmaterias.Text;
            dgv3[3, posic].Value = txtnota1.Text;
            dgv3[4, posic].Value = txtnota2.Text;
            dgv3[5, posic].Value = txtnota3.Text;
            dgv3[6, posic].Value = txtcum.Text;



        }

        private void button5_Click(object sender, EventArgs e)
        {
            int prome, n1, n2, n3;
            n1 = int.Parse(txtnota1.Text);
            n2 = int.Parse(txtnota2.Text);
            n3 = int.Parse(txtnota3.Text);
            prome = (n1 + n2 + n3) / 3;
            txtpromedio.Text = Convert.ToString(prome);
        }
    }
}
