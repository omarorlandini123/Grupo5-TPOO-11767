using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaBD.Entidades
{
    public class Curso
    {
        
        public string NombreCurso { get; set; }

        public Curso(string nombreCurso)
        {
            NombreCurso = nombreCurso;
        }
    }
}
