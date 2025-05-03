using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Exceptions
{
    internal class Exceptions
    {
        public class MontoNoValido : Exception
        {
            public MontoNoValido(String mensaje) : base(mensaje) { }
        }
        public class CuentaNoActiva : Exception
        {
            public CuentaNoActiva(String mensaje) : base(mensaje) { }
        }
        public class SaldoInsuficiente : Exception
        {
            public SaldoInsuficiente(String mensaje) : base(mensaje) { }
        }
    }
}