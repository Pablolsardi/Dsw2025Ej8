using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    public class CuentaCorriente : CuentaBancaria
    {
        private decimal _limiteDeDescubierto (get;init;);
        private decimal _comision (get;set);

        public CuentaCorriente(string numero, decimal saldo, string[] titulares) 
        {
            Estado = Estado.Activa;
        }

        public override void Depositar(decimal monto)
        {
            _monto -= monto * _comision;
            _saldo += monto;
        }

        public override void Retirar(decimal monto)
        {
            if (_saldo - monto >= -_limiteDeDescubierto)
            {
                _saldo -= monto;
            }
            if (_saldo < 0)
            {
                _estado = Estado.Suspendida;
            }
        }

    }
}


