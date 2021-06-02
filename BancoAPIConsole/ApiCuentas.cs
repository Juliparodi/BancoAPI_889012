using BancoAPIEntidades.entities;
using BancoAPIEntidades.exceptions;
using BancoAPINegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoAPIConsole
{
    public partial class ApiCuentas : Form
    {
        CuentaNegocio _cuentaNegocio;
        ClienteNegocio _clienteNegocio;
        public ApiCuentas(Form1 form)
        {
            this.Owner = form;
            _cuentaNegocio = new CuentaNegocio();
            _clienteNegocio = new ClienteNegocio();
            InitializeComponent();
        }

        private void ApiCuentas_Load(object sender, EventArgs e)
        {
            try
            {
                limpiar();
                this.lblBienvenida.Text = "Bienvenidos a la API CUENTAS, en el combo box encontraras los clientes!";
                this.cmbClientesCtasActivas.DataSource = null;
                this.cmbClientesCtasActivas.DataSource = _clienteNegocio.TraerTodos();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void limpiar()
        {
            txtActivo.Text = String.Empty;
            txtDescripcion.Text = String.Empty;
            txtIdCliente.Text = String.Empty;
            txtNroCuenta.Text = String.Empty;
            txtSaldo.Text = String.Empty;
        }

        private void cmbClientesCtasActivas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                limpiar();
                llenarCampoDatosCuentaCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void llenarCampoDatosCuentaCliente()
        {

            Cliente cliente = (Cliente)this.cmbClientesCtasActivas.SelectedValue;
            if(cliente == null)
            {
                throw new Exception("No se encontro al cliente");
            }

            Cuenta cuenta = _cuentaNegocio.TraerCuentaPorIdCliente(cliente.id);
            if (cuenta == null)
            {
                limpiar();
                txtIdCliente.Text = cliente.id.ToString();
                txtIdCliente.Enabled = false;
                txtActivo.Text = "true";
                txtActivo.Enabled = false;
                txtNroCuenta.Enabled = false;
                txtSaldo.Enabled = false;
            } else
            {
                llenarCamposNoVacios(cuenta);
            }
           
        }

        private void btnClientesCtasActivas_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
                this.cmbClientesCtasActivas.DataSource = null;
                this.cmbClientesCtasActivas.DataSource = _cuentaNegocio.TraerClientesCtasActivas();
                MessageBox.Show("Para ver los clientes con ctas activas x favor abra el combo box");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void llenarCamposNoVacios(Cuenta cuenta)
        {
            txtNroCuenta.Text = cuenta.NroCuenta.ToString();
            txtNroCuenta.Enabled = false;
            txtDescripcion.Text = cuenta.Descripcion.ToString();
            txtSaldo.Text = cuenta.Saldo.ToString();
            txtSaldo.Enabled = false;
            txtActivo.Text = cuenta.Activo ? "activo" : "inactivo";
            txtActivo.Enabled = false;
            txtIdCliente.Text = cuenta.IdCliente.ToString();
            txtIdCliente.Enabled = false;
        }

        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            validar();
            Cuenta cuenta = _cuentaNegocio.AgregarCuenta(txtNroCuenta.Text, txtDescripcion.Text, txtIdCliente.Text, txtSaldo.Text);
            if(cuenta != null)
            {
                MessageBox.Show("Se agrego exitosame la cuenta con id: " + cuenta.Id);
            }
        }

        private void validar()
        {
            float saldo;
            int nroCuenta;
            if(txtActivo.Text==null || txtDescripcion.Text == null || txtNroCuenta.Text == null || txtSaldo.Text == null)
            {
                throw new Exception("Por favor completar todos los campos");
            }

            if (!int.TryParse(txtNroCuenta.Text, out nroCuenta))
            {
                throw new Exception("Solo se aceptan numeros para el nro d cuenta");
            }
            else
            {
                txtNroCuenta.Text = nroCuenta.ToString();
            }

            if (!float.TryParse(txtSaldo.Text, out saldo))
            {
                throw new Exception("Solo se aceptan numeros para el nro d cuenta");
            }
            else
            {
                txtSaldo.Text = saldo.ToString();
            }

     
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();

        }
    }
}
