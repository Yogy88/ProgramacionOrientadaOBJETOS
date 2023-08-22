using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _27_SistemaDeFacturacion
{
    class Producto
    {
        public int Precio { get; set; }
        public int CodigoDelProducto { get; set; }
        public int IVA { get; set; }
        public int Cantidad { get; set; }
        public string NombreDelProducto { get; set; }
        public Decimal Subtotal()
        {
            return Precio * Cantidad;
        }
        public Decimal GranTotal()
        {
            return ((Precio * Cantidad) * IVA);
        }
    }
}
