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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCajero_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == "Ingrese su Usuario" && txtPassword.Text == "Ingrese su Contraseña")
                {
                    MessageBox.Show("Ingrese un usuario y contraseña para continuar");
                }
                else
                {
                    TextReader InicioDeSesion = new StreamReader(txtUser.Text + ".txt");

                    if (InicioDeSesion.ReadLine() == txtPassword.Text)
                    {
                        MessageBox.Show("Inicio de Sesión Exitoso" + "\nBienvenido " + txtUser.Text + " ^-^");
                        this.Hide();
                        RegistroCajero registrocajero = new RegistroCajero();
                        registrocajero.Show();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El usuario " + txtUser.Text + " no está registrado" + "\nRegistre un usuario para poder continuar");
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Ingrese su Usuario";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Ingrese su Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Ingrese su Contraseña";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Ingrese su Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void chbMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMostrar.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnMinimizarLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
