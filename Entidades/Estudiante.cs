using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaBD.Entidades
{
    public class Estudiante : Persona
    {
        public string CodigoEstudiante { get; set; }
        public string Grupo { get; set; }

        public Estudiante(string nombre, string apellido, string dni, string codigoEstudiante, string grupo)
            : base(nombre, apellido, dni)
        {
            CodigoEstudiante = codigoEstudiante;
            Grupo = grupo;
        }
    }
}
