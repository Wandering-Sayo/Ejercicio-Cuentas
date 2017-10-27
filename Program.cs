using System;
using System.Collections.Generic;

namespace Ejercicio_Cuentas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Titular> ListaTitulares = new List<Titular>();

            Titular cliente = new Titular ();
            cliente.Apellido = "Ledo";
            cliente.Nombre = "Jose Luis";

            List<Cuenta> ListaCuentas = new List<Cuenta>();

            Cuenta cuenta = new Cuenta ();
            cuenta.NumeroCuenta = 0260256427;
            cuenta.Saldo = 34560;
            cuenta.Cliente1 = cliente;

           
            Console.WriteLine("Bienvenido " + cuenta.Cliente1.Nombre + cuenta.Cliente1.Apellido);
            Console.WriteLine("Su número de cuenta es: " + cuenta.NumeroCuenta);
            
        }
    }
}
