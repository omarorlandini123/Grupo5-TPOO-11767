using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaBD.Pantallas_Administrador
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void btnMAGregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAadmin_Click(object sender, EventArgs e)
        {
            PantGESadmin pantalla = new PantGESadmin();
                pantalla.Show();
            this.Close();
        }

        private void bynAprofesor_Click(object sender, EventArgs e)
        {
            PantGESprofesor pantalla = new PantGESprofesor();
            pantalla.Show();
            this.Close();
        }

        private void btnAestudiante_Click(object sender, EventArgs e)
        {
            PantGESestudiante pantalla = new PantGESestudiante();
            pantalla.Show();
            this.Close();
        }

        private void btnAcursogrupo_Click(object sender, EventArgs e)
        {
            PantGEScursosgrupos pantalla = new PantGEScursosgrupos();
            pantalla.Show();
            this.Close();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnGAPadre_Click(object sender, EventArgs e)
        {
            PantGESpadres pantalla = new PantGESpadres();
            pantalla.Show();
            this.Close();
        }
    }
}
