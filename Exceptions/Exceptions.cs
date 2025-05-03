using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Exceptions
{
    internal class Exceptions
    {
        public class MontoInvalido : Exception
        {
            public MontoInvalido(String mensaje) : base(mensaje) { }
        }
        public class CuentaInactiva : Exception
        {
            public CuentaInactiva(String mensaje) : base(mensaje) { }
        }
        public class SaldoInsuficiente : Exception
        {
            public SaldoInsuficiente(String mensaje) : base(mensaje) { }
        }
    }
}