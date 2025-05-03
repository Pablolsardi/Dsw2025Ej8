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
        public decimal _tasaDeInteres { get; init; }

        public CajaAhorro(string numero, decimal saldo, string[] titulares) : base(numero, saldo, titulares) { }

        public override void Depositar(decimal monto)
        {
            if (_estado!=Estado.Activa) throw new CuentaNoActiva($"No se puede operar con la cuenta {_estado.ToString()}");
            if (monto <=0 ) throw new MontoNoValido("El monto ingresado no es válido para la operación solicitada");
            _saldo += monto;
        }

        public override void Retirar(decimal monto)
        {
            if (_estado != Estado.Activa) throw new CuentaNoActiva($"No se puede operar con la cuenta {_estado.ToString()}");
            if (monto <= 0) throw new MontoNoValido("El monto ingresado no es válido para la operación solicitada");
            if ((_saldo - monto) < 0)
            {
                _estado = Estado.Suspendida;
                throw new SaldoInsuficiente("La cuenta no cuenta con saldo para la operación solicitada. Fue suspendida.");
            }
            _saldo -= monto;
        }

        public void AplicarInteres()         
        {
            if (_estado != Estado.Activa) throw new CuentaNoActiva($"No se puede operar con la cuenta {_estado.ToString()}");
            _saldo += _saldo* _tasaDeInteres;
        }
    }
}


