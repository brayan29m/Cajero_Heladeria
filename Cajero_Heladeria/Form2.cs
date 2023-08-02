using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero_Heladeria
{
    public partial class BuscarCliente : Form
    {
        public Helados helados = new Helados();
        public BuscarCliente()
        {
            InitializeComponent();
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.Date.ToString("d");
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            dgvBuscar.DataSource = helados.HeladoXCliente(txtBuscar.Text);
        }

        private void btnCerrarBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroCajero registroCajero = new RegistroCajero();
            registroCajero.Show();
        }

        private void btnMinimizarBuscar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
