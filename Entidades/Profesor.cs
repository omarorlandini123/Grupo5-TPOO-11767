using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaBD.Entidades
{
    public class Profesor : Persona
    {
        public string CodigoProfesor { get; set; }
        public string Especialidad { get; set; }

        public Profesor(string nombre, string apellido, string dni, string codigoProfesor, string especialidad)
            : base(nombre, apellido, dni)
        {
            CodigoProfesor = codigoProfesor;
            Especialidad = especialidad;
        }
    }
}
