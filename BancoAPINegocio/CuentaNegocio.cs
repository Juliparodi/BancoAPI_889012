using BancoAPIDatos;
using BancoAPIEntidades.entities;
using BancoAPIEntidades.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAPINegocio
{
    public class CuentaNegocio
    {

        CuentaMapper _cuentaMapper;
        ClienteNegocio _clienteNegocio;

        public CuentaNegocio()
        {
            _cuentaMapper = new CuentaMapper();
            _clienteNegocio = new ClienteNegocio();
        }

        public List<Cliente> TraerClientesCtasActivas()
        {
            List<Cliente> clientes = _clienteNegocio.TraerTodos();
            List<Cuenta> cuentasClientesActivos = _cuentaMapper.TraerTodos()
                .Where(cu => cu.Activo && !String.IsNullOrEmpty(cu.IdCliente.ToString()))
                .ToList();
            List<Cliente> clienteCtasActivas = new List<Cliente>();
            
            foreach (Cuenta cuenta in cuentasClientesActivos)
            {
                Cliente cliente = clientes.FirstOrDefault(cli => cli.id == cuenta.IdCliente);
                if(cliente != null)
                {
                    clienteCtasActivas.Add(cliente);
                }
            }

            if (!clienteCtasActivas.Any())
            {
                throw new CuentasSinClientesActivosException("no se encontraron clientes con cuentas activas");
            }
            return clienteCtasActivas;
            
        }

        public Cuenta TraerCuentaPorIdCliente(int id)
        {
            List<Cuenta> cuentas = _cuentaMapper.TraerTodos();
            Cuenta cuenta = cuentas.FirstOrDefault(cu => cu.IdCliente == id);
            return cuenta;
            
        }

        public Cuenta AgregarCuenta(string nroCuenta, string descripcion, string idCLiente, string saldo)
        {
            try
            {
                Random random = new Random();
                Cuenta cuenta = new Cuenta();
                cuenta.Id = random.Next(50);
                cuenta.Activo = true;
                cuenta.NroCuenta = int.Parse(nroCuenta);
                cuenta.Descripcion = descripcion;
                cuenta.IdCliente = int.Parse(idCLiente);
                cuenta.Saldo = float.Parse(saldo);
                cuenta.FechaApertura = DateTime.Now;
                cuenta.FechaModificacion = DateTime.Now;

                return _cuentaMapper.Insertar(cuenta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);              
            }
        }
    }
}
