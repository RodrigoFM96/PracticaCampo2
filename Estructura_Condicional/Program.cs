using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aqui ingresamos el nombre del estudiante y se almacenara en la variable "nombre"//
            Console.WriteLine("Ingresar el nombre del estudiante: ");
            string nombre = Console.ReadLine();

            //Aqui se debe ingresar la nota1, nota2 y nota 3, donde se almacenara en respectivas variables//
            Console.WriteLine("Ingresar nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar nota 3: ");
            double nota3 = double.Parse(Console.ReadLine());
            // creamos las variables promedio y resultado//
            double promedio = (nota1 + nota2 + nota3) / 3;
            string resultado;
            //si el promedio da a los parametros establecidos indicara un resultado //
            if (promedio >= 18)
            {
                resultado = "excelente";
            }
            else if (promedio >= 14)
            {
                resultado = "Bueno";
            }
            else if (promedio >= 11)
            {
                resultado = "Regular";
            }
            else
            {
                resultado = "Desaprobado";
            }
            //mostrara en pantalla nombre del estudiante, promedio y el resultado //
            Console.WriteLine($"Estudiante: {nombre}");
            Console.WriteLine($"Promedio: {promedio:f2}");
            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadKey();
        }
    }
}
