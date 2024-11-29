using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaBD.Entidades
{
    public class Administrador : Persona
    {
        public string CodigoAdministrador { get; set; }

        public Administrador(string nombre, string apellido, string dni, string codigoAdministrador)
            : base(nombre, apellido, dni)
        {
            CodigoAdministrador = codigoAdministrador;
        }
    }
}
