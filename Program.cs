using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ejercicio_Cuentas
{
    class Program
    {
        /// <summary>
        /// Muestra el menú de operaciónes a realizar
        /// </summary>
        static void MostrarMenu()
        {
            Console.WriteLine("¿Qué operación desea realizar?");
            Console.WriteLine();
            Console.WriteLine("1- Consulta de Saldo");
            Console.WriteLine("2- Depósito");
            Console.WriteLine("3- Extracción");
            Console.WriteLine("4- Últimos Movimientos");
            Console.WriteLine("0- Salir");
        }

        static void Main(string[] args)
        {
            List<Cliente> ListaClientes = new List<Cliente>();

            Cliente cliente1 = new Cliente ();
            cliente1.Apellido = "Moreno";
            cliente1.Nombre = "Alicia Liliana";
            cliente1.Email = "almovilo@gmail.com";
            double numero = 02204832437;
            string telefono = numero.ToString("(###) ###-####");
            cliente1.Telefono = telefono; 
            cliente1.FechaNacimiento = new DateTime(1956, 7, 23);

            List<Cuenta> ListaCuentas = new List<Cuenta>();

            Cuenta cuenta = new Cuenta ();
            cuenta.NumeroCuenta = 0260256427;
            cuenta.Saldo = 60000;
            cuenta.Titular = cliente1;

           
            Console.WriteLine(string.Format("Bienvenido {0}, {1}", cuenta.Titular.Apellido , cuenta.Titular.Nombre));
            Console.WriteLine("Su número de cuenta es: " + cuenta.NumeroCuenta);
            //Console.WriteLine("Su teléfono de contacto es " + cuenta.Titular.Telefono);

            MostrarMenu();
            int operacion = int.Parse(Console.ReadLine());
            List<string> listaMovimientos = new List<string>();
            while(operacion!=0)
            {
                switch(operacion)
                {
                    case 1:
                        cuenta.ConsultarSaldo();
                        string movSaldo = "Se ha realizado una consulta de saldo ";
                        listaMovimientos.Add(movSaldo);
                        Console.WriteLine();
                        MostrarMenu();
                        operacion = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        decimal saldoDeposito= cuenta.Saldo;
                        Console.WriteLine("Ingrese saldo a depositar");
                        decimal deposito= decimal.Parse(Console.ReadLine());
                        decimal depositar = Cuenta.Despositar(saldoDeposito,deposito);
                        Console.WriteLine("Se han depositado {0} en su cuenta.", deposito.ToString("C", CultureInfo.CreateSpecificCulture("es-AR")));
                        Console.WriteLine("Su saldo actual es de " + depositar.ToString("C", CultureInfo.CreateSpecificCulture("es-AR")));
                        string movDeposito = "Se ha realizado un depósito de " + deposito.ToString("C", CultureInfo.CreateSpecificCulture("es-AR"));
                        listaMovimientos.Add(movDeposito);
                        cuenta.Saldo = depositar;
                        MostrarMenu();
                        operacion = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        decimal saldoExtraccion= cuenta.Saldo;
                        Console.WriteLine("Ingrese saldo a extraer");
                        decimal extraccion= decimal.Parse(Console.ReadLine());
                        decimal extraer = Cuenta.Extraer(saldoExtraccion,extraccion);
                        Console.WriteLine("Se han extraído {0} de su cuenta.", extraccion.ToString("C", CultureInfo.CreateSpecificCulture("es-AR")));
                        Console.WriteLine("Su saldo actual es de " + extraer.ToString("C", CultureInfo.CreateSpecificCulture("es-AR")));
                        string movExtraccion = "Se ha realizado una extracción de " + extraccion.ToString("C", CultureInfo.CreateSpecificCulture("es-AR"));
                        listaMovimientos.Add(movExtraccion);
                        cuenta.Saldo = extraer;
                        MostrarMenu();
                        operacion = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Últimos movimientos de la cuenta");
                        foreach(string item in listaMovimientos)
                            {
                                Console.WriteLine(item);
                            }
                        MostrarMenu();
                        operacion = int.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Opción Inválida. Por favor inténtelo nuevamente");
                        MostrarMenu();
                        operacion = int.Parse(Console.ReadLine());
                        break;
                }
            }

            
        }
    }
}
