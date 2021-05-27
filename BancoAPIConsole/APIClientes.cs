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
            lstClientes.DataSource = _clienteNegocio.TraerTodos();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            validar();
            TransactionResult transactionResult =_clienteNegocio.Agregar(txtNombre.Text, txtApellido.Text, dateTimePicker.Value, txtDNI.Text, txtDireccion.Text);
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
        
}
}
