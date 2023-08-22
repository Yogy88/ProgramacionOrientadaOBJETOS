using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _28_Vehiculos
{
    class Moto : Vehiculo//Aqui se establece la herencia
                         //Esta clase recibira todas las propiedades de la clase Vehiculo
                         //Para hacerla heredera, basta con utilizar los 2 punto ":" y poner el nombre de la clase invocada
    {
        public int Autonomia { get; set; }
        public string Color { get; set; }
        public override void Encender() //La palabra "OVERRRIDE" sobreescribe para invocar el "Encender" de Vehiculo
                                        // para que muestre por pantalla el encendido de esta clase puntual
        {
            base.Encender();
            Console.WriteLine("Moto encendida");
        }
    }
}
