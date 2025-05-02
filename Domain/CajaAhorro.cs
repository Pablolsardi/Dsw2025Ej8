using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    public class CajaAhorro : CuentaBancaria
    {
        private decimal _tasaDeInteres;

        public CajaDeAhorro(string numero, decimal saldo, string[] titulares){ }

        public override void Depositar(decimal monto)
        {
            _saldo += monto;
        }

        public override void Retirar(decimal monto)
        {
            _saldo -= monto;
        }

        public void AplicarInteres()         
        {
            _saldo += _saldo* _tasaDeInteres;
        }
    }
}


