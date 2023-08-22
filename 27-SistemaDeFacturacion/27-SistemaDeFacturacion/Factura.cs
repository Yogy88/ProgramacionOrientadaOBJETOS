using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _27_SistemaDeFacturacion
{
    class Factura
    {
        public Cliente DatosCliente { get; set; }
        public Vendedor DatosVendedor { get; set; }
        public string CondicionDePago { get; set; }
        public int NumeroDeFactura { get; set; }
        public DateTime FechaDeEmision { get; set; }

        public List<Producto> Productos { get; set; }

        Producto a = new Producto();

        public Factura()
        {
            this.Productos = new List<Producto>();
        }
    }
}
