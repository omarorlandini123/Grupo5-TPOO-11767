using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaBD.Entidades
{
    public class Notas
    {
        public int Calificacion { get; set; }
        public DateTime Fecha { get; set; }
        public string CodigoEstudiante { get; set; }
        public string CodigoCurso { get; set; }

        public Notas(int calificacion, DateTime fecha, string codigoEstudiante, string codigoCurso)
        {
            Calificacion = calificacion;
            Fecha = fecha;
            CodigoEstudiante = codigoEstudiante;
            CodigoCurso = codigoCurso;
        }
    }
}
