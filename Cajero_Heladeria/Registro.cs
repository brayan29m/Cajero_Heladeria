using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cajero_Heladeria
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnRegistroUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "" && txtContraseña.Text == "")
                {
                    MessageBox.Show("Ingrese un usuario y contraseña para continuar");
                }
                else
                {
                    TextWriter RegistrarUsuario = new StreamWriter(@"C:\Users\Acer\source\repos\Cajero_Heladeria\Cajero_Heladeria\bin\Debug\" + txtUsuario.Text + ".txt", true);
                    RegistrarUsuario.WriteLine(txtContraseña.Text);
                    RegistrarUsuario.Close();
                    MessageBox.Show("El usuario se registró correctamente");
                    txtUsuario.Clear();
                    txtContraseña.Clear();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Hubo un Error" + x, "Error");
            }
        }

        private void btnCerrarRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void chbMostrarRegistro_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMostrarRegistro.Checked == true)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void btnMinimizarRegistro_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
