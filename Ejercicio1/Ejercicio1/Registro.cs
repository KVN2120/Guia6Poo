using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ejercicio1
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection Conexion = Miconexion.ObtnerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Table (Nombres, Apellidos, Edad, Direccion) values ('{0}', '{1}','{2}','{3}')",
                   txtnombre.Text, txtapellido.Text, txtedad.Text, txtdireccion.Text), Conexion);

                int Resul = Comando.ExecuteNonQuery();
                Conexion.Close();

                if (Resul > 0)
                    MessageBox.Show("Datos Guardados Correctamente!!", "Guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Guardar!!", "Error al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
