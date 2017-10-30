using System;
using System.Globalization;

namespace Ejercicio_Cuentas
{
    /// <summary>
    /// Clase Cuenta
    /// </summary>
    public class Cuenta
    {
        public long NumeroCuenta { get; set; }

        public decimal Saldo { get; set; }

        public Cliente Titular { get; set; }

        public Cliente Cotitular { get; set; }

        /// <summary>
        /// Operación Consulta de Saldo
        /// </summary>
        /// <returns>Saldo</returns>        
        public int ConsultarSaldo()
        {
            Console.WriteLine("Su saldo es de " + Saldo.ToString("C", CultureInfo.CreateSpecificCulture("es-AR")));
            return 0;
        }

        /// <summary>
        /// Operación Depósito
        /// </summary>
        /// <param name="operando1">Saldo actual</param>
        /// <param name="operando2">Cantidad a depositar</param>
        /// <returns>Suma de saldo más depósito</returns>
        public static decimal Despositar(decimal operando1, decimal operando2)
        {
            decimal deposito = operando1 + operando2;
            return deposito;
        }

        /// <summary>
        /// Operación Extracción
        /// </summary>
        /// <param name="operando1">Saldo actual</param>
        /// <param name="operando2">Cantidad a extraer</param>
        /// <returns>Diferencia de saldo menos extracción</returns>
        public static decimal Extraer(decimal operando1, decimal operando2)
        {
            decimal extraccion = operando1 - operando2;
            return extraccion;
        }
    
    }
}