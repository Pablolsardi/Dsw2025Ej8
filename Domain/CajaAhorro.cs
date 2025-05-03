using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dsw2025Ej8.Exceptions;
using static Dsw2025Ej8.Exceptions.Exceptions;

namespace Dsw2025Ej8.Domain
{
    public class CajaAhorro : CuentaBancaria
    {
        private decimal _tasaDeInteres { get; init; }

        public CajaAhorro(string numero, decimal saldo, string[] titulares) : base(numero, saldo, titulares) { }

        public override void Depositar(decimal monto)
        {
            if (_estado!=Estado.Activa) throw new CuentaInactiva(" No se puede operar con la cuenta | estado: " + _estado.ToString());
            if (monto <=0 ) throw new MontoInvalido(" El monto ingresado no es valido");
            _saldo += monto;
        }

        public override void Retirar(decimal monto)
        {
            if (_estado != Estado.Activa) throw new CuentaInactiva(" No se puede operar con la cuenta | estado: " + _estado.ToString());
            if (monto <= 0) throw new MontoInvalido(" El monto ingresado no es valido");
            if ((_saldo - monto) < 0)
            {
                _estado = Estado.Suspendida;
                throw new SaldoInsuficiente("La cuenta no posee saldo suficiente para realizar la operacion, la cuenta ha sido suspendida.");
            }
            _saldo -= monto;
        }

        public void AplicarInteres()         
        {
            if (_estado != Estado.Activa) throw new CuentaInactiva(" No se puede operar con la cuenta | estado: " + _estado.ToString());
            _saldo += _saldo* _tasaDeInteres;
        }
    }
}


