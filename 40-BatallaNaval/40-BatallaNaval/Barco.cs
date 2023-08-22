using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _40_BatallaNaval
{
    class Barco
    {
        // Posiciones: '0'=Desocupado --'1'=Ocupado--'2'=Tocado--'3'=Hundido
        public int TamañoDelBarco { get; set; }
        public string NombreDelBarco { get; set; }
        public string EstadoDelBarco { get; set; }
        public int PosicionDelBarco { get; set; }
    }
}
