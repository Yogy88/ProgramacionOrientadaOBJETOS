using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//vendedor> (definido por usuario EN EL FINAL)
// nombre
//              mes (12) (por numero)>
//                                      nombre (del 1 al 12)
//                                      Producto
//                                      Precio

//ingresar e imprimir los datos del vendedor, preguntar si desea continuar, si continua
// debera ingresar otro vendedor, sino, le muestra las ventas registradas en la corrida del programa
            
namespace Ventasdelmes_191107
{
    class vendedor
    {
        
       public string NombreVendedor { get; set; }

        public List <mes> meses { get; set; }

        public vendedor ()

        {
            this.meses = new List<mes>();

        }
    }
}
