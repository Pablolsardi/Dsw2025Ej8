using System.Runtime.CompilerServices;

namespace Dsw2025Ej8.Domain;

public abstract class CuentaBancaria
{
    #region Propiedades
    public string _numero { get; }
    public decimal _saldo { get; protected set; }
    public Estado _estado{ get; set; }
    public string[] _titulares { get; }
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

}