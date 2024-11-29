using pruebaBD.Entidades;
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
    public partial class PantGESadmin : Form
    {
        // Cadena de conexión a tu base de datos
        string connectionString = "Server=localhost; Database=MonitoreoNotasTpoo; Integrated Security=True;";

        public PantGESadmin()
        {
            InitializeComponent();
            CargarRegistros(); // Cargar registros al inicio
        }

        private void InsertarAdministradorEnBD(Administrador administrador)
        {
            // Conexión a la base de datos
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    conn.Open();

                    // Consulta SQL para insertar los datos
                    string query = "INSERT INTO Administradores (Nombre, Apellido, DNI, Codigo) VALUES (@Nombre, @Apellido, @DNI, @Codigo)";

                    // Crear el comando SQL
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Agregar los parámetros de la consulta
                    cmd.Parameters.AddWithValue("@Nombre", administrador.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", administrador.Apellido);
                    cmd.Parameters.AddWithValue("@DNI", administrador.DNI);
                    cmd.Parameters.AddWithValue("@Codigo", administrador.CodigoAdministrador);

                    // Ejecutar la consulta
                    cmd.ExecuteNonQuery();

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Administrador ingresado con éxito.");

                    // Llamar a un método para recargar los registros (si es necesario)
                    CargarRegistros();
                }
                catch (Exception ex)
                {
                    // Mostrar mensaje de error si ocurre alguna excepción
                    MessageBox.Show("Error al ingresar el administrador: " + ex.Message);
                }
            }
        }

        // Método para cargar los registros desde la base de datos al DataGridView
        private void CargarRegistros()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Administradores"; 
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable; // Asigna los datos al DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los registros: " + ex.Message);
                }
            }
        }

        private void txtGANombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGAApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGACod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGADNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGAdmAgregar_Click(object sender, EventArgs e)
        {
            // Capturando los datos desde los campos de texto
            string nombre = txtGANombre.Text.Trim();
            string apellido = txtGAApellido.Text.Trim();
            string dni = txtGADNI.Text.Trim();
            string codigoAdministrador = txtGACod.Text.Trim();

            // Verificando que todos los campos estén completos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(codigoAdministrador))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Crear una nueva instancia de Administrador
            Administrador nuevoAdministrador = new Administrador(nombre, apellido, dni, codigoAdministrador);

            // Llamar al método InsertarAdministradorEnBD para insertar el nuevo administrador
            InsertarAdministradorEnBD(nuevoAdministrador);
        }

        private void btnGAdmEliminar_Click(object sender, EventArgs e)
        {
            string codigo = txtGACod.Text.Trim();  // Eliminar espacios en blanco al principio y al final

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Por favor ingresa un código válido.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Comprobar si el administrador existe antes de intentar eliminarlo
                    string checkQuery = "SELECT COUNT(*) FROM Administradores WHERE Codigo = @Codigo";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Codigo", codigo);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("No se encontró un administrador con ese código.");
                        return;
                    }

                    // Ahora eliminar el registro
                    string query = "DELETE FROM Administradores WHERE Codigo = @Codigo";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = codigo;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Administrador eliminado con éxito.");
                    CargarRegistros(); // Recargar los registros
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el administrador: " + ex.Message);
                }
            }
        }

        private void btnGAregresar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.Show();
        }
    }
}
