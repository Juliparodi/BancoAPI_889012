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
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }


        private void btnAPIClientes_Click(object sender, EventArgs e)
        {
            APIClientes FormApiClientes = new APIClientes(this);
            FormApiClientes.Show();
            this.Hide();
        }

        private void btnAPICuentas_Click(object sender, EventArgs e)
        {
            ApiCuentas formApiCuentas = new ApiCuentas(this);
            formApiCuentas.Show();
            this.Hide();
        }
    }
}
