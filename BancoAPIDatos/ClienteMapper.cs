using BancoAPIEntidades.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAPIDatos
{
    public class ClienteMapper
    {
        public List<Cliente> TraerTodos()
        {
            string json2 = WebHelper.Get("cliente"); // trae un texto en formato json de una web
            List<Cliente> resultado = MapList(json2);
            return resultado;
        }

        private List<Cliente> MapList(string json)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return lst;
        }

        private Cliente MapObjectCliente(string json)
        {
            Cliente cli = JsonConvert.DeserializeObject<Cliente>(json);
            return cli;
        }
        public TransactionResult Insertar(Cliente cliente)
        {
            try
            {
                NameValueCollection obj = ReverseMap(cliente);

                string json = WebHelper.Post("cliente", obj);

                TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

                return lst;
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                throw new Exception("ha ocurrido un error al insertar elementos");
            }
        }
        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", cliente.id.ToString());
            n.Add("nombre", cliente.Nombre);
            n.Add("apellido", cliente.Ape);
            n.Add("direccion", cliente.Direccion);
            n.Add("DNI", cliente.DNI);
            n.Add("fechaNacimiento",cliente.FechaNac.ToString("yyyy-MM-dd"));
            n.Add("telefono", cliente.Telefono.ToString());
            n.Add("usuario", "1");
            return n;
        }

        public Cliente TraerPorTelefono(string telefono)
        {
            try
            {
                string url = "cliente/" + telefono + "/telefono";
                string json2 = WebHelper.Get(url);
                Cliente resultado = MapObjectCliente(json2);
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error al traer clientes x telefono");
            }
        }
    }
}
