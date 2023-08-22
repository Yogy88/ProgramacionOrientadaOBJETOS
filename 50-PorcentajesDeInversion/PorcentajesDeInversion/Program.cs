using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PorcentajesDeInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Inversores = new int[3];
            int Contador = 0;
            int TotalInvertido = 0;
            int i = 0;

            Console.WriteLine("Ingrese los montos invertidos de cada contribuyente:");

            for ( i=0; i<Inversores.Length; i++)
            {
                Inversores[i] = Convert.ToInt32(Console.ReadLine());
                Contador = Inversores[i];

            }

            TotalInvertido = (Inversores[i] * 100) / 3;

            Console.WriteLine(TotalInvertido);
            Console.ReadKey();
        }
    }
}
