using BancoAPIDatos;
using BancoAPIEntidades.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAPINegocio
{
    public class ClienteNegocio
    {
        List<Cliente> listaClientes;
        ClienteMapper clienteMapper;

        public ClienteNegocio()
        {
            listaClientes = new List<Cliente>();
            clienteMapper = new ClienteMapper();
        }

        public List<Cliente> TraerTodos()
        {
            return clienteMapper.TraerTodos();
        }

        public TransactionResult Agregar(string nombre, string apellido, DateTime fechaNac, string dni, string direccion)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Nombre = nombre;
                cliente.Ape = apellido;
                cliente.DNI = dni;
                cliente.Direccion = direccion;
                cliente.FechaNac = fechaNac;


                return clienteMapper.Insertar(cliente);
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                throw new Exception("ha ocurrido un error al insertar elementos");
            }
        }
    }
}
