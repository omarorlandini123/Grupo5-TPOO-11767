using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaBD.Entidades
{
    internal class Padres : Persona
    {
        public string CodigoPadres { get; set; }

        public Padres(string nombre, string apellido, string dni, string codigoPadres)
            : base(nombre, apellido, dni)
        {
            CodigoPadres = codigoPadres;
        }
    }
}
