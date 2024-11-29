using pruebaBD.Pantallas;
using pruebaBD.Pantallas_Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaBD
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdministrador_Click(object sender, EventArgs e)
        {
           MenuAdmin pantalla = new MenuAdmin();
            pantalla.Show();
           ;   

        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            PantVistaProfesor pantalla = new PantVistaProfesor();
            pantalla.Show();
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            PantVistaEstudiantes pantalla = new PantVistaEstudiantes();
            pantalla.Show();
        }

        private void btnPadre_Click(object sender, EventArgs e)
        {
            PantVistaPadres pantalla = new PantVistaPadres();
            pantalla.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
