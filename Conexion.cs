using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace pruebaBD
{
    internal class Conexion
    {
        // Cadena de conexión que usará la autenticación integrada de Windows
        private readonly string _connectionString;

        // Constructor que inicializa la cadena de conexión
        public Conexion()
        {
            _connectionString = "Server=localhost; Database=MonitoreoNotasTpoo; Integrated Security=True;";
        }

        // Método para obtener la conexión
        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        // Método para probar la conexión a la base de datos
        public void TestConnection()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexión exitosa a la base de datos.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }
    }
}
