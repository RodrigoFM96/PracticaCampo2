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
            //vareable para almacenar el saldo inicial y la opcion elegida por el usuario
            double saldo = 1000;
            int opcion;
            //ciclo do-while: se repetira hasta llegar a la opcion 4
            do
            {
            //Menu de opciones que el usuario eligira
                Console.WriteLine("--- Cajero Automático ---");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Depositar dinero");
                Console.WriteLine("3. Retirar dinero");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                
               //depende de la opcion elegida se ejecutan los casos
                switch (opcion)
                {
                        //aqui muestra el saldo inicial que es 1000
                    case 1:
                        Console.WriteLine($"Su saldo actual es: {saldo}");
                        break;
                    case 2: 
                        //aqui muestra la cantidad a depositar que se le sumara al saldo inicial
                        Console.Write("Ingrese monto a depositar: ");
                        double deposito = double.Parse(Console.ReadLine());
                        saldo += deposito;
                        Console.WriteLine("Depósito realizado con éxito.");
                        break;
                    case 3:
                        // aqui el usuario debe ingresar la cantidad a retirar, no debe ser mayor al saldo 
                        Console.Write("Ingrese monto a retirar: ");
                        double retiro = double.Parse(Console.ReadLine());
                        if (retiro <= saldo)
                        {
                            // si el monto del retiro es menor, se descontara del saldo 
                            saldo -= retiro;
                            // aqui indicara que el retiro fue aceptado.
                            Console.WriteLine("Retiro exitoso.");
                        }
                        else
                            //caso contrario se mostrara saldo insuficiente
                        {
                            Console.WriteLine("Saldo insuficiente.");
                        }
                        break;
                    case 4:
                        //mensaje de despedida, al salir 
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

