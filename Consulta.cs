using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Veterinario
{
    public partial class Consulta : Form
    {
        private DataTable tabla;
        DataGridViewRow fila = new DataGridViewRow();

        public Consulta()
        {
            InitializeComponent();


        }

        public Consulta(List<CllsControlServicio> listaControlServicio)
        {
            InitializeComponent();


            tabla = new DataTable();

            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Nombre Mascota", typeof(string));
            tabla.Columns.Add("Detalle revision", typeof(string));
            tabla.Columns.Add("servicio", typeof(string));
            tabla.Columns.Add("vacunas", typeof(string));
            tabla.Columns.Add("fecha vacunas", typeof(string));
            tabla.Columns.Add("total a pagar", typeof(string));


            for (int i = 0; i < listaControlServicio.Count; i++)
            {

                CboTodosCli.Items.Add(listaControlServicio[i].Nombre);
                CboTodMasc.Items.Add(listaControlServicio[i].NombreMascota);
                tabla.Rows.Add(listaControlServicio[i].Nombre, listaControlServicio[i].NombreMascota, listaControlServicio[i].Detalle,
                                listaControlServicio[i].Servicio, listaControlServicio[i].Vacuna, listaControlServicio[i].Fecha, listaControlServicio[i].Pago);
                dataGridView1.DataSource = tabla;
            }

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            if ((CboTodosCli.Text.Equals("")) & (CboTodMasc.Text.Equals("")))
            {
                MessageBox.Show("No existen datos que Buscar", "Veterinaria AIEP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Visible = false;
            }
            else if (tabla == null)
            {
                MessageBox.Show("No existen datos que Buscar", "Veterinaria AIEP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataView dv = tabla.DefaultView;
                dv.RowFilter = "Nombre LIKE '" + CboTodosCli.Text + "%'";
                dataGridView1.DataSource = dv;
                dataGridView1.Visible = true;
            }



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            if (tabla == null)
            {
                MessageBox.Show("No existen datos que Elimaar", "Veterinaria AIEP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ( tabla.Rows.Count ==0)
            {
                MessageBox.Show("No existen datos que Elimaar", "Veterinaria AIEP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Esta seguro que desea eliminar el registro ", "Veterinaria AIEP", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
              
                fila = dataGridView1.CurrentRow;
                dataGridView1.Rows.Remove(fila);

            }

          

        }
    }
}
