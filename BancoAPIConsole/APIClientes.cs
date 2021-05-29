using BancoAPIEntidades.entities;
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
    public partial class APIClientes : Form
    {
         List<Cliente> _listaClientes;
        ClienteNegocio _clienteNegocio;
        public APIClientes(Form1 form1)
        {
            this.Owner = form1;
            _listaClientes = new List<Cliente>();
            _clienteNegocio = new ClienteNegocio();
            InitializeComponent();
        }

        private void APIClientes_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            lstClientes.DataSource = null;
            _listaClientes = _clienteNegocio.TraerTodos();
            lstClientes.DataSource = _listaClientes;
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            validar();
            TransactionResult transactionResult =_clienteNegocio.Agregar(txtNombre.Text, txtApellido.Text, dateTimePicker.Value, txtDNI.Text, txtDireccion.Text, txtTelefono.Text);
            if (!transactionResult.IsOk)
            {
                MessageBox.Show("Ha ocurrido el siguiente error: " + transactionResult.Error);
            } else
            {
                MessageBox.Show("Los registros se insertaron correctamente, por favor actualize");
            }
        }

        private void validar()
        {
            int DNINumber;
            if (dateTimePicker.Value == null)
            {
                throw new Exception("Por favor ingresar fecha");
            }

            if (txtApellido.Text == null || txtDireccion.Text == null || txtDNI.Text == null || txtNombre == null)
            {
                throw new Exception("Parametros invalidos, intente nuevamente");
            }

            if(!int.TryParse(txtDNI.Text, out DNINumber)){
                throw new Exception("Solo se aceptan numeros");
            }
            else
            {
                txtDNI.Text = DNINumber.ToString();
            }
           
        }

        private void btnTraerXTelefono_Click(object sender, EventArgs e)
        {
            try
            {
                validarTelefono();
                lstClientes.DataSource = null;
                Cliente cliente = _clienteNegocio.TraerPorTelefono(txtTelefono.Text);
                _listaClientes.Add(cliente);
                MessageBox.Show(cliente.ToString());
                lstClientes.DataSource = _listaClientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Actualizar();
            }

        }

        private void validarTelefono()
        {
            int telefono;
            if (txtTelefono.Text == null)
            {
                throw new Exception("Por favor incluir telefono");
            }

            if (!int.TryParse(txtTelefono.Text, out telefono))
            {
                throw new Exception("Solo se aceptan numeros");
            }
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstClientes.SelectedIndex == null )
                {
                    throw new Exception("Por favor parese en algun cliente");
                }
                Cliente cliente = (Cliente)lstClientes.SelectedValue;
                if (cliente == null)
                {
                    throw new Exception("Cliente vacio");
                }
                txtNombre.Text = cliente.Nombre==null ? "" : cliente.Nombre;
                txtDireccion.Text = cliente.Direccion==null? "" : cliente.Direccion;
                txtApellido.Text = cliente.Ape==null ? "" : cliente.Ape;
                txtDNI.Text = cliente.DNI == null ? "" : cliente.DNI.ToString();
                txtTelefono.Text = cliente.Telefono == null ? "" : cliente.Telefono.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
