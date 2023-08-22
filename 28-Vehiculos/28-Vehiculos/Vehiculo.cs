using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _28_Vehiculos
{
    class Vehiculo //Esta es la clase padre
                   //De esta clase obtendran PROPEDADES las clase Auto y Moto
    {
        public int CantidadDeRuedas { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int CntidadDePuertas { get; set; }
        public virtual void Encender() //La palabra "virtual" permite la sobre-escritura de este METODO
                                       //La clase hijo que va a sobreescribir DEBE llevar el override, caso contrario NO sobreescribirá
        {
            Console.WriteLine("Ingreso de llave");
            Console.WriteLine("Generar chispa");
            Console.WriteLine("Vehiculo encendido");
        }


    }
}
