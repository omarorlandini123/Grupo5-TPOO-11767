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
    public partial class PantVistaPadres : Form
    {
        // Cadena de conexión a tu base de datos
        string connectionString = "Server=localhost; Database=MonitoreoNotasTpoo; Integrated Security=True;";
        public PantVistaPadres()
        {
            InitializeComponent();
        }

        private void bTNbUSCAResT_Click(object sender, EventArgs e)
        {
            // Obtener el código del estudiante del TextBox
            string codigoEstudiante = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(codigoEstudiante))
            {
                MessageBox.Show("Por favor, ingrese un código de estudiante.");
                return;
            }

            // Buscar las notas del estudiante
            BuscarNotasEstudiante(codigoEstudiante);
        }
        // Método para buscar las notas del estudiante
        private void BuscarNotasEstudiante(string codigoEstudiante)
        {
            // Crear conexión con la base de datos
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    conn.Open();

                    // Consulta SQL para obtener las notas del estudiante
                    string query = "SELECT CodigoNota, NombreCurso, Calificacion, FechaIngreso FROM Notas WHERE CodigoEstudiante = @CodigoEstudiante";

                    // Crear el comando SQL
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CodigoEstudiante", codigoEstudiante);

                    // Crear un adaptador de datos
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    // Crear un DataTable para almacenar los resultados
                    DataTable dt = new DataTable();

                    // Llenar el DataTable con los resultados de la consulta
                    da.Fill(dt);

                    // Asignar el DataTable al DataGridView
                    dataGridView1.DataSource = dt;

                    // Verificar si no se encontraron registros
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron notas para este estudiante.");
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    MessageBox.Show("Error al buscar las notas: " + ex.Message);
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //TEXTBOX PARA INGRESAR EL ESTUDIANTE A BUSCAR
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
