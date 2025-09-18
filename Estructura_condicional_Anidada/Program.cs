using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables para almacenar la edad y el ingreso
            int edad;
            double ingresoMensual;
            Console.WriteLine("--- Sistema de Verificación de Préstamos ---");

            // Solicitar la edad al usuario y validar la entrada
            Console.Write("Por favor, ingrese su edad: ");

            if (int.TryParse(Console.ReadLine(), out edad))
            {
                // La primera condición verifica si la edad está dentro del rango para un préstamo.
                if (edad >= 20 && edad <= 65)
                {
                    // Si la edad es válida, pasamos a la siguiente condición anidada.
                    Console.Write("Por favor, ingrese su ingreso mensual (en S/.): ");

                    if (double.TryParse(Console.ReadLine(), out ingresoMensual))
                    {
                        // La segunda condición anidada verifica el ingreso mensual.
                        if (ingresoMensual >= 1500)
                        {
                            // Si ambas condiciones se cumplen, el usuario es elegible.
                            Console.WriteLine("¡Felicidades! Usted es elegible para un préstamo.");
                        }
                        else
                        {
                            // Este 'else' corresponde a la condición del ingreso.
                            Console.WriteLine("Lo sentimos, su ingreso mensual no cumple con el requisito mínimo.");
                        }
                    }
                    else
                    {
                        // Mensaje de error si el ingreso no es un número válido.
                        Console.WriteLine("Entrada de ingreso no válida. Por favor, ingrese un número.");
                    }
                }
                else
                {
                    // Este 'else' corresponde a la primera condición (la de la edad).
                    Console.WriteLine("Lo sentimos, su edad no cumple con el rango requerido para un préstamo.");
                }
            }
            else
            {
                // Mensaje de error si la edad no es un número válido.
                Console.WriteLine("Entrada de edad no válida. Por favor, ingrese un número entero.");
            }

            Console.WriteLine("--- Fin del Proceso ---");

        }
    }
}
