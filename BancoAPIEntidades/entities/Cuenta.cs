using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BancoAPIEntidades.entities
{
    [DataContract]
    public class Cuenta
    {
        public class Root
        {
            int _nroCuenta;
            string _descripcion;
            int _saldo;
            DateTime _fechaApertura;
            DateTime _fechaModificacion;
            bool _activo;
            int _idCliente;
            int _id;

            [DataMember(Name = "nroCuenta")]
            public int NroCuenta { get => _nroCuenta; set => _nroCuenta = value; }
            [DataMember(Name = "descripcion")]
            public string Descripcion { get => _descripcion; set => _descripcion = value; }
            [DataMember(Name = "saldo")]
            public int Saldo { get => _saldo; set => _saldo = value; }
            [DataMember(Name = "fechaApertura")]
            public DateTime FechaApertura { get => _fechaApertura; set => _fechaApertura = value; }
            [DataMember(Name = "fechaModificacion")]
            public DateTime FechaModificacion { get => _fechaModificacion; set => _fechaModificacion = value; }
            [DataMember(Name = "actico")]
            public bool Activo { get => _activo; set => _activo = value; }
            [DataMember(Name = "idCliente")]
            public int IdCliente { get => _idCliente; set => _idCliente = value; }
            [DataMember(Name = "id")]
            public int Id { get => _id; set => _id = value; }

        }
    }
}
