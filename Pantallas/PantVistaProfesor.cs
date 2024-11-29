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

namespace pruebaBD.Pantallas
{
    public partial class PantVistaProfesor : Form
    {
        // Cadena de conexión a tu base de datos
        string connectionString = "Server=localhost; Database=MonitoreoNotasTpoo; Integrated Security=True;";
        public PantVistaProfesor()
        {
            InitializeComponent();
        }

        private void Profesores_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCaliicacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string codigoNota = txtCodNota.Text;
            string codigoEstudiante = txtCodAlumno.Text;
            string curso = txtCurso.Text;
            decimal calificacion;

            // Validar que la calificación sea un número válido
            if (!decimal.TryParse(txtCaliicacion.Text, out calificacion))
            {
                MessageBox.Show("Por favor, ingrese una calificación válida.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Notas (CodigoNota, CodigoEstudiante, NombreCurso, Calificacion) VALUES (@CodigoNota, @CodigoEstudiante, @NombreCurso, @Calificacion)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CodigoNota", codigoNota);
                    cmd.Parameters.AddWithValue("@CodigoEstudiante", codigoEstudiante);
                    cmd.Parameters.AddWithValue("@NombreCurso", curso);
                    cmd.Parameters.AddWithValue("@Calificacion", calificacion);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Nota registrada con éxito.");
                    CargarNotas(); // Recargar las notas en el DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la nota: " + ex.Message);
                }
            }
        }
        private void CargarNotas()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CodigoNota, CodigoEstudiante, NombreCurso, Calificacion, FechaIngreso FROM Notas";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable notasTable = new DataTable();
                    adapter.Fill(notasTable);
                    dataGridViewNotasProfesor.DataSource = notasTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las notas: " + ex.Message);
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string codigoNota = txtCodNota.Text; // Código de la nota que se desea eliminar

            // Verificar que se haya ingresado un código
            if (string.IsNullOrWhiteSpace(codigoNota))
            {
                MessageBox.Show("Por favor, ingrese el código de la nota a eliminar.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Notas WHERE CodigoNota = @CodigoNota";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CodigoNota", codigoNota);

                    int rowsAffected = cmd.ExecuteNonQuery(); // Ejecuta la consulta y devuelve las filas afectadas

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Nota eliminada con éxito.");
                        CargarNotas(); // Recargar las notas en el DataGridView
                    }
                    else
                    {
                        MessageBox.Show("No se encontró una nota con el código ingresado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la nota: " + ex.Message);
                }
            }
        }

        private void dataGridViewNotasProfesor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMenuVisProfe_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
