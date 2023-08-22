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
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorLeft = 25;
            Console.WriteLine ("Programa de Ventas" );
            Console.WriteLine(" ");
            
            List<vendedor> vendedores = new List<vendedor>();

            Console.WriteLine("Ingrese la cantidad de vendedores");
            int cantvend = Convert.ToInt32(Console.ReadLine());

            
                for ( int i =0; i <cantvend ;i++ )
                {
                int imasuno = i + 1;
                vendedor a = new vendedor ();

                Console.WriteLine ("Ingrese el nombre del vendedor : " + imasuno);

                a.NombreVendedor = Console.ReadLine ();

                vendedores.Add(a);

                Console.WriteLine("Ingrese la cantidad de meses a ingresar : ");
                int cantmeses = Convert.ToInt32(Console.ReadLine());
                
                
                for (int j=0 ; j<cantmeses ;j++) 
               
                    
                {
                    int jmasuno = j+1;
                    mes B = new mes ();
                    Console.WriteLine ("Ingrese el numero de mes de la posicion : " + jmasuno + " del vendedor " + imasuno);

                    B.NumeroMes = Convert.ToInt32 ( Console.ReadLine ());

                    Console.WriteLine("Ingrese el Producto de mes de la posicion: " + jmasuno + " del vendedor " + imasuno);

                    B.Producto = Console.ReadLine ();

                    Console.WriteLine("Ingrese Precio de la posicion: " + jmasuno + " del vendedor " + imasuno);

                    B.Precio = Convert.ToInt32 ( Console.ReadLine ());

                    a.meses.Add (B);
                    }

                Console.Clear();
                }
                    

            for (int i = 0; i < vendedores.Count; i++)

            {
                
                vendedor leervendedor = vendedores[i];

                

                Console.WriteLine("Nombre del Vendedor = " + leervendedor.NombreVendedor);

                for (int j = 0; j < leervendedor.meses.Count; j++)
                {

                    mes leermes = leervendedor.meses[j];

                    Console.WriteLine("Numero de mes = " + leermes.NumeroMes);

                    Console.WriteLine("Producto = " + leermes.Producto);

                    Console.WriteLine("Precio = " + leermes.Precio);
                }
            }
                
            Console.ReadKey();
           
        }
    }
}
