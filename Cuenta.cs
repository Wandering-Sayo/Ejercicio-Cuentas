using System;

namespace Ejercicio_Cuentas
{
    /// <summary>
    /// Clase Cuenta
    /// </summary>
    public class Cuenta
    {
        public long NumeroCuenta { get; set; }

        public decimal Saldo { get; set; }

        public Titular Cliente1 { get; set; }
    
    }
}