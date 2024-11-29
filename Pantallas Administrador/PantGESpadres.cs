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
    public partial class PantGESpadres : Form
    {
        // Cadena de conexión a tu base de datos
        string connectionString = "Server=localhost; Database=MonitoreoNotasTpoo; Integrated Security=True;";
        public PantGESpadres()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void btnEliminarPa_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Padres WHERE Codigo = @Codigo";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Padre eliminado con éxito.");
                        CargarRegistros(); // Recargar la tabla
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un padre con ese código.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar padre: " + ex.Message);
                }
            }
        }

        private void btnAgregarPa_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDNI.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Padres (Codigo, Nombre, Apellido, DNI) VALUES (@Codigo, @Nombre, @Apellido, @DNI)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@DNI", dni);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Padre agregado con éxito.");
                    CargarRegistros(); // Recargar la tabla
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar padre: " + ex.Message);
                }
            }
        }
        private void CargarRegistros()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Padres";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewPadres.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los registros: " + ex.Message);
                }
            }
        }
        private void dataGridViewPadres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPadres.Rows[e.RowIndex];
                txtCodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                txtDNI.Text = row.Cells["DNI"].Value.ToString();
            }
        }

        private void PantGESpadres_Load(object sender, EventArgs e)
        {

        }
    }
}
