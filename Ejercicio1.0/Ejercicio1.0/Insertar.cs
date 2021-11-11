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


namespace Ejercicio1._0
{
    public partial class Insertar : Form
    {
        public Insertar()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = Miconexion.ObtnerConexion();

            SqlCommand Comando = new SqlCommand(string.Format("Insert Into Personas(Nombres, Apellidos, Edad, Direccion) values('{0}', '{1}','{2}','{3}')",
               txtNombre.Text, txtApellido.Text, txtEdad.Text, txtDireccion.Text),Conexion);

            int Resultado = Comando.ExecuteNonQuery();
            Conexion.Close();

            if (Resultado > 0)
                MessageBox.Show("Datos Guardados Correctamente!!", "Guardados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo Guardar!!", "Error al Guardar!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
