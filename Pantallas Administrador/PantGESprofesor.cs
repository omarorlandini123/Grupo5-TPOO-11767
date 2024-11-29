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
    public partial class PantGESprofesor : Form
    {
        // Cadena de conexión a tu base de datos
        string connectionString = "Server=localhost; Database=MonitoreoNotasTpoo; Integrated Security=True;";
        public PantGESprofesor()
        {
            InitializeComponent();
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

        private void txtEspecialidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtiene los valores de las cajas de texto
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDNI.Text;
            string especialidad = txtEspecialidad.Text;

            // Establece una conexión con la base de datos usando la cadena de conexión
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // Abre la conexión a la base de datos

                    // Define el comando SQL para insertar un nuevo registro
                    string query = "INSERT INTO Profesores (Codigo, Nombre, Apellido, DNI, Especialidad) VALUES (@Codigo, @Nombre, @Apellido, @DNI, @Especialidad)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Asocia los valores de las cajas de texto a los parámetros del comando
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@DNI", dni);
                    cmd.Parameters.AddWithValue("@Especialidad", especialidad);

                    // Ejecuta el comando
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Profesor agregado con éxito."); // Muestra un mensaje de éxito

                    CargarRegistros(); // Llama al método para actualizar la tabla de datos en pantalla
                }
                catch (Exception ex)
                {
                    // Captura y muestra cualquier error que ocurra durante el proceso
                    MessageBox.Show("Error al agregar profesor: " + ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtiene el código del profesor desde la caja de texto
            string codigo = txtCodigo.Text;

            // Establece una conexión con la base de datos usando la cadena de conexión
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // Abre la conexión a la base de datos

                    // Define el comando SQL para eliminar un registro basado en el código
                    string query = "DELETE FROM Profesores WHERE Codigo = @Codigo";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Asocia el valor del código a los parámetros del comando
                    cmd.Parameters.AddWithValue("@Codigo", codigo);

                    // Ejecuta el comando y almacena la cantidad de filas afectadas
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Si se afectó al menos una fila, muestra un mensaje de éxito
                        MessageBox.Show("Profesor eliminado con éxito.");
                        CargarRegistros(); // Actualiza la tabla de datos en pantalla
                    }
                    else
                    {
                        // Si no se afectó ninguna fila, muestra un mensaje de advertencia
                        MessageBox.Show("No se encontró un profesor con ese código.");
                    }
                }
                catch (Exception ex)
                {
                    // Captura y muestra cualquier error que ocurra durante el proceso
                    MessageBox.Show("Error al eliminar profesor: " + ex.Message);
                }
            }
        }

        private void CargarRegistros()
        {
            // Establece una conexión con la base de datos usando la cadena de conexión
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // Abre la conexión a la base de datos

                    // Define el comando SQL para seleccionar todos los registros de la tabla Profesores
                    string query = "SELECT * FROM Profesores";

                    // Usa un adaptador para llenar un DataTable con los resultados de la consulta
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Asigna el DataTable como fuente de datos para el DataGridView
                    dataGridViewProfesores.DataSource = dt;
                }
                catch (Exception ex)
                {
                    // Captura y muestra cualquier error que ocurra durante el proceso
                    MessageBox.Show("Error al cargar los registros: " + ex.Message);
                }
            }
        }

        private void dataGridViewProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que se haya hecho clic en una fila válida
            if (e.RowIndex >= 0)
            {
                // Obtiene la fila seleccionada en el DataGridView
                DataGridViewRow row = dataGridViewProfesores.Rows[e.RowIndex];

                // Asigna los valores de las celdas de la fila seleccionada a las cajas de texto
                txtCodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                txtDNI.Text = row.Cells["DNI"].Value.ToString();
                txtEspecialidad.Text = row.Cells["Especialidad"].Value.ToString();
            }
        }
    }
}
