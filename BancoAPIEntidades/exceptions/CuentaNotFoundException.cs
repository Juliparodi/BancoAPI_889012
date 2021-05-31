using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAPIEntidades.exceptions
{
   public class CuentaNotFoundException : Exception
    {
        string _message;

        public CuentaNotFoundException(string msg) : base()
        {
            _message = msg;
        }
    }
}
