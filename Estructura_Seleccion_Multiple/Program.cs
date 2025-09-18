using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Seleccion_Multiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo = 1000;
            int opcion;
            do
            {
                Console.WriteLine("--- Cajero Automático ---");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Depositar dinero");
                Console.WriteLine("3. Retirar dinero");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"Su saldo actual es: {saldo}");
                        break;
                    case 2:
                        Console.Write("Ingrese monto a depositar: ");
                        double deposito = double.Parse(Console.ReadLine());
                        saldo += deposito;
                        Console.WriteLine("Depósito realizado con éxito.");
                        break;
                    case 3:
                        Console.Write("Ingrese monto a retirar: ");
                        double retiro = double.Parse(Console.ReadLine());
                        if (retiro <= saldo)
                        {
                            saldo -= retiro;
                            Console.WriteLine("Retiro exitoso.");
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Gracias por usar el cajero,vuelva pronto.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida,elegir otra opcion.");
                        break;
                }

            } while (opcion != 4);

            Console.ReadKey();
        }
    }
}
