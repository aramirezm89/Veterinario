using System;
using System.Windows.Forms;

namespace Veterinario
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnClienteMascota_Click(object sender, EventArgs e)
        {
            Cliente_Mascota frm = new Cliente_Mascota();
            frm.Show();

        }

        private void BtnIngresarControlServicio_Click(object sender, EventArgs e)
        {
            ControlServicio frm = new ControlServicio();
            frm.Show();
        }

        private void BtnConsultarControlServicio_Click(object sender, EventArgs e)
        {
            Consulta frm = new Consulta();
            frm.Show();
        }

        private void BtnEliminarControlServicio_Click(object sender, EventArgs e)
        {
            Consulta frm = new Consulta();
            frm.Show();
        }
    }
}
