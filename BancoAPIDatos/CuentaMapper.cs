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
    public class CuentaMapper
    {
        public List<Cuenta> TraerTodos()
        {
            string json2 = WebHelper.Get("cuenta"); 
            return MapList(json2);
        }

        private List<Cuenta> MapList(string json)
        {
            return JsonConvert.DeserializeObject<List<Cuenta>>(json);
        }

        private Cuenta MapObjectCliente(string json)
        {
            return JsonConvert.DeserializeObject<Cuenta>(json);
        }

        private NameValueCollection ReverseMap(Cuenta cuenta)
        {
            NameValueCollection n = new NameValueCollection();

            n.Add("idCliente", cuenta.IdCliente.ToString());
            n.Add("Descripcion", cuenta.Descripcion);

            /*
            n.Add("nroCuenta", cuenta.NroCuenta.ToString());
            n.Add("descripcion", cuenta.Descripcion);
            n.Add("saldo", cuenta.Saldo.ToString("0.00"));
            n.Add("fechaApertura", cuenta.FechaApertura.ToString("yyyy-MM-dd"));
            n.Add("fechaModificacion", cuenta.FechaModificacion.ToString("yyyy-MM-dd"));
            n.Add("activo", cuenta.Activo.ToString());
            n.Add("idCliente", cuenta.IdCliente.ToString());
            n.Add("id", cuenta.Id.ToString());
            */
            return n;
        }

        public Cuenta Insertar(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMap(cuenta);

            string json = WebHelper.Post("cuenta", obj);

            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);

            if (!lst.IsOk)
            {
                throw new Exception("No se pudo ingresar la cuenta para el id cliente: " + cuenta.IdCliente);
            } else
            {
                return cuenta;
            }
        }
    }
}
