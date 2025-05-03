using Dsw2025Ej8.Domain;

namespace Dsw2025Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CajaAhorro cuenta1 = new CajaAhorro("666", 5000, ["Lopez Sardi, Pablo"]) {_tasaDeInteres=0.02M};
            CajaAhorro cuenta2 = new CajaAhorro("777", 4000, ["Litninsky, José Ignacio"]) {_tasaDeInteres=0.03M};
            CuentaCorriente cuenta3 = new CuentaCorriente("888", 9000, ["Muñoz, Luciano Ezequiel"]) {_limiteDeDescubierto=2000};
            CuentaCorriente cuenta4 = new CuentaCorriente("555", 2000, ["Doe, John"]) {_limiteDeDescubierto=100}; 


            try
            {
                cuenta1.Depositar(2000);
                cuenta1.Retirar(5000);
                cuenta1.Retirar(2001);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
           

            try
            {
                cuenta1.Depositar(2);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }


            try
            {
                cuenta2.Retirar(2000);
                cuenta2.AplicarInteres();
                cuenta2.Depositar(0);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }


            try
            {
                cuenta3.Retirar(8000);
                cuenta3.Depositar(2000);
                cuenta3.Retirar(5001);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }


            try
            {
                cuenta3.Depositar(6000);
                cuenta3.Retirar(2500);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            try
            {
                cuenta4.Retirar(1000);
                cuenta4.Depositar(-1);
            }
             catch (Exception ex) { Console.WriteLine(ex.Message); }


            var cuentas = new List<CuentaBancaria>();
            cuentas.Add(cuenta1);
            cuentas.Add(cuenta2);
            cuentas.Add(cuenta3);
            cuentas.Add(cuenta4);

            var resumenCuentas = cuentas.Select(c => new
            {
                Numero = c._numero,
                Tipo = c.GetType().Name,
                Titulares = string.Join(", ", c._titulares),
                Estado = c._estado.ToString(),
                Saldo = c._saldo
            }
            );

            foreach (var cuenta in resumenCuentas)
            {
                Console.WriteLine($"Cuenta N° {cuenta.Numero} - Tipo: {cuenta.Tipo} - Titulares: {cuenta.Titulares} - Estado: {cuenta.Estado} - Saldo: ${cuenta.Saldo}");
            }


        }
    }
}
