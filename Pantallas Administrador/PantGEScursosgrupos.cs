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
    public partial class PantGEScursosgrupos : Form
    {
        // Cadena de conexión a tu base de datos
        string connectionString = "Server=localhost; Database=MonitoreoNotasTpoo; Integrated Security=True;";
        public PantGEScursosgrupos()
        {
            InitializeComponent();
        }

        private void InsertarCursoEnBD(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO Cursos (NombreCurso) VALUES (@Nombre)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Curso agregado con éxito.");
                    CargarCursos(); // Actualiza la vista de los cursos
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el curso: " + ex.Message);
                }
            }
        }
        private void EliminarCursoDeBD(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "DELETE FROM Cursos WHERE NombreCurso = @Nombre";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Curso eliminado con éxito.");
                    CargarCursos(); // Actualiza la vista de los cursos
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el curso: " + ex.Message);
                }
            }
        }
        private void CargarCursos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT NombreCurso FROM Cursos";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewCursos.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los cursos: " + ex.Message);
                }
            }
        }
        private void InsertarGrupoEnBD(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO Grupos (NombreGrupo) VALUES (@Nombre)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Grupo agregado con éxito.");
                    CargarGrupos(); // Actualiza la vista de los grupos
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el grupo: " + ex.Message);
                }
            }
        }
        private void EliminarGrupoDeBD(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "DELETE FROM Grupos WHERE NombreGrupo = @Nombre";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Grupo eliminado con éxito.");
                    CargarGrupos(); // Actualiza la vista de los grupos
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el grupo: " + ex.Message);
                }
            }
        }

        private void CargarGrupos()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT NombreGrupo FROM Grupos";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewGrupo.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los grupos: " + ex.Message);
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la fila seleccionada no sea el encabezado
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCursos.Rows[e.RowIndex];

                // Asignar el valor de la celda al control correspondiente
                textNomCruso.Text = row.Cells["NombreCurso"].Value.ToString();
            }
        }
    

        private void textNomCruso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            string nombreCurso = textNomCruso.Text.Trim();

            if (string.IsNullOrEmpty(nombreCurso))
            {
                MessageBox.Show("Por favor, ingrese el nombre del curso.");
                return;
            }

            InsertarCursoEnBD(nombreCurso);
        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            string nombreCurso = textNomCruso.Text.Trim();

            if (string.IsNullOrEmpty(nombreCurso))
            {
                MessageBox.Show("Por favor, ingrese el nombre del curso a eliminar.");
                return;
            }

            EliminarCursoDeBD(nombreCurso);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.Show();
        }

        private void txtNomGrupo_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnAGregarGRupo_Click(object sender, EventArgs e)
        {
            string nombreGrupo = txtNomGrupo.Text.Trim();

            if (string.IsNullOrEmpty(nombreGrupo))
            {
                MessageBox.Show("Por favor, ingrese el nombre del grupo.");
                return;
            }

            InsertarGrupoEnBD(nombreGrupo);
        }

        private void btnEliminarGrupo_Click(object sender, EventArgs e)
        {
            string nombreGrupo = txtNomGrupo.Text.Trim();

            if (string.IsNullOrEmpty(nombreGrupo))
            {
                MessageBox.Show("Por favor, ingrese el nombre del grupo a eliminar.");
                return;
            }

            EliminarGrupoDeBD(nombreGrupo);
        }

        private void dataGridViewGrupo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la fila seleccionada no sea el encabezado
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewGrupo.Rows[e.RowIndex];

                // Asignar el valor de la celda al control correspondiente
                txtNomGrupo.Text = row.Cells["NombreGrupo"].Value.ToString();
            }
        }
    }
}
