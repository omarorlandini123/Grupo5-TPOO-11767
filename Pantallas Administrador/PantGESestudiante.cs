using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaBD.Pantallas_Administrador
{
    public partial class PantGESestudiante : Form
    {
        // Cadena de conexión a tu base de datos
        string connectionString = "Server=localhost; Database=MonitoreoNotasTpoo; Integrated Security=True;";
        public PantGESestudiante()
        {
            InitializeComponent();
        }
        private void CargarRegistros()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Estudiantes";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewEstudiantes.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los registros: " + ex.Message);
                }
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.Show();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDNI.Text;
            string grupo = txrGRupo.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Estudiantes (Codigo, Nombre, Apellido, DNI, Grupo) VALUES (@Codigo, @Nombre, @Apellido, @DNI, @Grupo)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@DNI", dni);
                    cmd.Parameters.AddWithValue("@Grupo", grupo);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Estudiante agregado con éxito.");
                    CargarRegistros(); // Recargar la tabla
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar estudiante: " + ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Estudiantes WHERE Codigo = @Codigo";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Estudiante eliminado con éxito.");
                        CargarRegistros(); // Recargar la tabla
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un estudiante con ese código.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar estudiante: " + ex.Message);
                }
            }
        }

        private void txrGRupo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
