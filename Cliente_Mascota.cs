using System.Collections.Generic;
using System.Windows.Forms;

namespace Veterinario
{
    public partial class Cliente_Mascota : Form
    {

        List<lista> cliente = new List<lista>();
        public Cliente_Mascota()
        {
            InitializeComponent();
            CboRaza.Items.Add("Persa");
            CboRaza.Items.Add("Angora");
            CboRaza.Items.Add("Pitbull");
            CboRaza.Items.Add("Bull dog");
            CboRaza.Items.Add("Sin raza");
            CboRaza.SelectedIndex = 0;
            CboTipMasc.Items.Add("Perro");
            CboTipMasc.Items.Add("Gato");
            CboTipMasc.Items.Add("Hamster");
            CboTipMasc.Items.Add("Conejo");
            CboTipMasc.SelectedIndex = 0;
            RbMacho.Checked = true;
            RbVacSi.Checked = true;
        }

        string sex;  //variable declarada para la opcion del radio buttom
        string vacunas;  //variable declarada para la opcion del radio buttom


        public void GuardarPersona()
        {
            if (TxtNombre.Text.Equals(""))
            {
                MessageBox.Show("No puedes guardar registro sin nombre de cliente ", "Veterinaria AIEP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (RbMacho.Checked == true)
                {
                    sex = "Macho";
                }

                if (RbHembra.Checked == true)
                {
                    sex = "Hembra";
                }


                if (RbVacSi.Checked == true)
                {
                    vacunas = "Si";
                }

                if (RbVacNo.Checked == true)
                {
                    vacunas = "No";
                }

                lista lista1 = new lista(TxtNombre.Text, TxtRut.Text, TxtDirec.Text, TxtEmail.Text, TxtFono.Text, sex, vacunas, TxtColor.Text, TxtNomMasc.Text, TxtEdadMasc.Text);

                cliente.Add(lista1);
                CboRaza.Items.Add(lista1.Nombre);
                
            }




        }

        public void SoloLetras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
                MessageBox.Show("Ingrese Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void TxtEdadMasc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solo_Numeros(e);
        }

        private void BtnCtrlServ_Click(object sender, System.EventArgs e)
        {
            ControlServicio frm = new ControlServicio(cliente);
            frm.Show();

        }

        private void BtnGuarDat_Click(object sender, System.EventArgs e)
        {
            GuardarPersona();


        }


    }


}

