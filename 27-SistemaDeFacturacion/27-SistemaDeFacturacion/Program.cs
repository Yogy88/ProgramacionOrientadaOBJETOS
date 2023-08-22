using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _27_SistemaDeFacturacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura F = new Factura();


            Producto p = new Producto();
            p.Precio = 10000;


            decimal x = 10.5M; // ASI SE DECLARAN LOS DECIMALES
            F.Productos.Add(p);





            Console.ReadKey();
        }
    }
}
