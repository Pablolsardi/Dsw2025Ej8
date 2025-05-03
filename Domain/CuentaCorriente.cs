using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dsw2025Ej8.Exceptions;
using static Dsw2025Ej8.Exceptions.Exceptions;

namespace Dsw2025Ej8.Domain
{
    public class CuentaCorriente : CuentaBancaria
    {
        private decimal _limiteDeDescubierto { get; init; }
        private decimal _comision{ get; set; }

        public CuentaCorriente(string numero, decimal saldo, string[] titulares) : base(numero, saldo, titulares)
        {
            _estado = Estado.Activa;
        }


        public override void Depositar(decimal monto)
        {
            if (_estado!=Estado.Activa) throw new CuentaInactiva(" No se puede operar con la cuenta | estado: " + _estado.ToString());
            if (monto <= 0) throw new MontoInvalido(" El monto ingresado no es valido");
            monto -= monto * _comision;
            _saldo += monto;
        }

        public override void Retirar(decimal monto)
        {
            if (_estado != Estado.Activa) throw new CuentaInactiva(" No se puede operar con la cuenta | estado: " + _estado.ToString());
            if (monto <= 0) throw new MontoInvalido(" El monto ingresado no es valido");
            if (((_saldo + _limiteDeDescubierto)-monto)<0)
            {
                _estado = Estado.Suspendida;
                throw new SaldoInsuficiente("La cuenta no cuenta con saldo para la operación solicitada. Fue suspendida.");
            }
            _saldo -= monto;
        }

    }
}


