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
    public partial class RegistroCajero : Form
    {
        Helados helados = new Helados();
        double precio = 0;

        public RegistroCajero()
        {
            InitializeComponent();
        }

        private void btnCerrarCajero_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizarCajero_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RegistroCajero_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("d");
            lblPrecio.Text = (0).ToString("C");
            cmbSabor.SelectedIndex = 0;
            cmbAderezo.SelectedIndex = 0;
            cmbTamanio.SelectedIndex = 0;
            cmbAdicional.SelectedIndex = 0;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbSabor.SelectedIndex == 0)
                MessageBox.Show("Debe seleccionar un Sabor...!!!");
            else if (cmbAderezo.SelectedIndex == 0)
                MessageBox.Show("Debe seleccionar un Aderezo...!!!");
            else if (cmbTamanio.SelectedIndex == 0)
                MessageBox.Show("Debe seleccionar un Tamaño...!!!");
            else if (cmbAdicional.SelectedIndex == 0)
                MessageBox.Show("Debe seleccionar un Adicional...!!!");
            else if (mskCantidad.Text == "")
                MessageBox.Show("Debe ingresar una Cantidad...!!!");
            else if (txtCliente.Text == "")
                MessageBox.Show("Debe ingresar un Nombre...!!!");
            else
            {
                Helado helado = new Helado();
                helado.Sabor = cmbSabor.SelectedItem.ToString();
                helado.Aderezo = cmbAderezo.SelectedItem.ToString();
                helado.Servicios = mskServicios.Text;
                helado.Tamanio = cmbTamanio.SelectedItem.ToString();
                helado.Adicional = cmbAdicional.SelectedItem.ToString();
                helado.Cantidad = mskCantidad.Text;
                helado.Cliente = txtCliente.Text;
                helados.Agregar(helado);
                MessageBox.Show("Pedido realizado con éxito");
                Limpiar();
                dgvDatos.DataSource = helados.ImprimirHelados();
            }
        }

        public void Limpiar()
        {
            cmbSabor.SelectedIndex = 0;
            cmbAderezo.SelectedIndex = 0;
            mskServicios.Clear();
            cmbTamanio.SelectedIndex = 0;
            cmbAdicional.SelectedIndex = 0;
            mskCantidad.Clear();
            txtCliente.Clear();
            lblPrecio.Text = (0).ToString("C");

        }

        private void cmbTamanio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tamanio = cmbTamanio.Text;

            if (tamanio.Equals("Supremo")) precio = 4.50;
            if (tamanio.Equals("Grande")) precio = 3.50;
            if (tamanio.Equals("Mediano")) precio = 2.50;
            if (tamanio.Equals("Pequeño")) precio = 1.50;
            if (tamanio.Equals("Cono")) precio = 0.75;

            lblPrecio.Text = precio.ToString("C");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCliente buscarcliente = new BuscarCliente();
            buscarcliente.Show();
            this.Hide();
            buscarcliente.helados = helados;
        }
    }
}
