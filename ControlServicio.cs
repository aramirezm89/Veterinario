using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Veterinario
{
    public partial class ControlServicio : Form
    {

        string vacuna; //variable para radio buttom vacunas
        string[] datos = new string[7];
        bool columnas = false; //variable con el fin de que la datatable no registre mas de una vez el nombre de los campos
        List<CllsControlServicio> listaControlServicio = new List<CllsControlServicio>();

        private DataTable tabla;


        public ControlServicio()
        {
            InitializeComponent();

            RbSiVac.Checked = true;
            CboSelecServ.Items.Add("Manicure");
            CboSelecServ.Items.Add("Peluqueria");
            CboSelecServ.Items.Add("Baño");
            CboSelecServ.Items.Add("Peluqueria");
            CboSelecServ.Items.Add("Atencion Medica");
        }



        public ControlServicio(List<lista> cliente)
        {
            InitializeComponent();
            CboSelecServ.Items.Add("Manicure");
            CboSelecServ.Items.Add("Peluqueria");
            CboSelecServ.Items.Add("Baño");
            CboSelecServ.Items.Add("Peluqueria");
            RbSiVac.Checked = true;

            for (int i = 0; i < cliente.Count; i++)
            {
                CboSelecCli.Items.Add(cliente[i].Nombre);
                CboSelecMasc.Items.Add(cliente[i].NombreMascota);

            }



        }

        private void RbNoVac_CheckedChanged(object sender, EventArgs e)
        {

            TxtPago.Enabled = false;
            DateTimeVacuna.Enabled = false;
            TxtPago.Text = "0";


        }

        private void RbSiVac_CheckedChanged(object sender, EventArgs e)
        {

            TxtPago.Enabled = true;
            DateTimeVacuna.Enabled = true;
            TxtPago.Text = "0";

        }


        private void BtnCServ_Click(object sender, System.EventArgs e)
        {
            Consulta frm = new Consulta(listaControlServicio);
            frm.Show();
        }

        private void ControlServicio_Load(object sender, EventArgs e)
        {

        }



        private void GuardarDatos() //datos del formulario
        {



            if (RbNoVac.Checked == true)
            {
                vacuna = "No";
             
            }

            if (RbSiVac.Checked == true)
            {
                vacuna = "Si";
            }


            datos[0] = CboSelecCli.Text;
            datos[1] = CboSelecMasc.Text;
            datos[2] = txtDetalle.Text;
            datos[3] = CboSelecServ.Text;
            datos[4] = vacuna;
            if (RbNoVac.Checked == true)
            {
                datos[5] = "";
            }else
            {
                datos[5] = DateTimeVacuna.Text;
            }
           
            datos[6] = TxtPago.Text;

            CllsControlServicio ListaDatos = new CllsControlServicio(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6]);

            listaControlServicio.Add(ListaDatos);





            if (columnas == false)
            {
                Tabla();
            }



            tabla.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6]);

           




        }

        private void BtnGDatos_Click(object sender, EventArgs e)
        {
            GuardarDatos();

        }

        private void Tabla()
        {
            tabla = new DataTable();

            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Nombre Mascota", typeof(string));
            tabla.Columns.Add("Detalle revision", typeof(string));
            tabla.Columns.Add("serviicio", typeof(string));
            tabla.Columns.Add("vacunas", typeof(string));
            tabla.Columns.Add("fecha vacunas", typeof(string));
            tabla.Columns.Add("total a pagar", typeof(string));

            columnas = true;
        }

        public void Solo_Numeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo Puede ingresar Numeros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void TxtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solo_Numeros(e);
        }
    }
}
