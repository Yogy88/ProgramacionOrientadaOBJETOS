using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _28_Vehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto A = new Auto(); //Cuando inicialicemos esto, vamos a invocar el "Encender" de la clase padre Vehiculo

            A.Encender();

            Moto B = new Moto();

            B.Encender();

            List<Vehiculo> Vehiculos = new List<Vehiculo>(); //Esta lista permite que invoquemos a todos los objetos
                                                             //que queremos que hereden de la clase Vehiculo
            Vehiculos.Add(A);
            Vehiculos.Add(B);

            foreach (Vehiculo v in Vehiculos)
            {
                Console.WriteLine(v.Marca);
                Console.WriteLine(v.Modelo);
                Console.WriteLine(v.Ano);
                v.Encender();
            }






            Console.ReadKey();
        }
    }
}
