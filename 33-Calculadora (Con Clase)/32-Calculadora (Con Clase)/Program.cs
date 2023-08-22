using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_Calculadora__Con_Clase_
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacionesMatematicas operaciones = new OperacionesMatematicas();

            Console.WriteLine("Bienvenido a la calculadora");

            Console.WriteLine("A los valores ingresados se les realizaran las 4 operaciones basicas: suma, resta, multiplicacion y division.");
            Console.WriteLine("Ingrese el primer valor: ");
            decimal numerouno = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor: ");
            decimal numerodos = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("El resultado de la suma es: " + operaciones.suma(numerouno, numerodos));

            Console.WriteLine("El resultado de la resta es: " + operaciones.resta(numerouno, numerodos));

            Console.WriteLine("El resultado de la multiplicacion es: " + operaciones.multiplicacion(numerouno, numerodos));

            Console.WriteLine("El resultado de la division es: " + operaciones.division(numerouno, numerodos));

            Console.ReadKey();
        }
    }
}
