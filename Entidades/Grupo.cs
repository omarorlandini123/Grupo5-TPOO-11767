using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaBD.Entidades
{
    public class Grupo
    {
        public string NombreGrupo { get; set; }

        public Grupo(string nombreGrupo)
        {
            NombreGrupo = nombreGrupo;
        }
    }
}
