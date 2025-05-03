using System.Runtime.CompilerServices;

namespace Dsw2025Ej8.Domain;

public abstract class CuentaBancaria
{
    #region Propiedades
    public string _numero(get;);
    public decimal _saldo(get;protected set);
    public Estado _estado(get;set);
    public string[] _titulares(get;);
    #endregion
    public CuentaBancaria(string numero, decimal saldo, string[] titulares)
    {
        _numero = numero;
        _saldo = saldo;
        _estado = Estado.Activa;
        _titulares = titulares;
    }

    public abstract void Depositar(decimal monto);

    public abstract void Retirar(decimal monto);

#region Funciones viejas
//public void Depositar(decimal monto)
//{
//    if (_tipo == TipoCuenta.CajaDeAhorro)
//    {
//        _saldo += monto;
//    }
//    else if (_tipo == TipoCuenta.CuentaCorriente)
//    {
//        monto -= monto * _comision;
//        _saldo += monto;
//    }
//}

//public void Retirar(decimal monto)
//{
//    if (_tipo == TipoCuenta.CajaDeAhorro)
//    {
//        _saldo -= monto;
//    }
//    else if (_tipo == TipoCuenta.CuentaCorriente)
//    {
//        if (_saldo - monto >= -_limiteDeDescubierto)
//        {
//            _saldo -= monto;
//        }
//        if (_saldo < 0)
//        {
//            _estado = Estado.Suspendida;
//        }
//    }
//}

//    public void AplicarInteres()          SOLO CAJA DE AHORRO
//    {
//        if (_tipo == TipoCuenta.CajaDeAhorro)
//        {
//            _saldo += _saldo * _tasaDeInteres;
//        }
//    }
//} 
#endregion