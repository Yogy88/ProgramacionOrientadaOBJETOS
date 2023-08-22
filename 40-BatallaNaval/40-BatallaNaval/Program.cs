using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _40_BatallaNaval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la batalla naval.");

            Console.WriteLine("Cuentas con 9 barcos en tu flota de diversos tamaños. " + Environment.NewLine + "Se ingresaran de mayor a menor.");
            Console.WriteLine("Ingresa las posiciones del primer barco que ocupara 5 unidades de espacio:");
            int Posicion1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa las posiciones del segundo barco que ocupara 5 unidades de espacio:");
            int Posicion2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la posicion del primer barco que ocupara 3 posiciones:");
            int Posicion3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la posicion del segundo barco que ocupara 3 posiciones:");
            int Posicion4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa las posiciones del primer barco que ocupara 2 unidades de espacio:");
            int Posicion5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa las posiciones del segundo barco que ocupara 2 unidades de espacio:");
            int Posicion6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la posicion del primer barco que ocupara 1 posicion:");
            int Posicion7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la posicion del segundo barco que ocupara 1 posicion:");
            int Posicion8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la posicion del tercer barco que ocupara 1 posicion:");
            int Posicion9 = Convert.ToInt32(Console.ReadLine());

            Barco BarcoGrande1 = new Barco();
            BarcoGrande1.PosicionDelBarco = Posicion1;

            Barco BarcoGrande2 = new Barco();
            BarcoGrande2.PosicionDelBarco = Posicion1;

            Barco BarcoMediano1 = new Barco();
            BarcoMediano1.PosicionDelBarco = Posicion1;

            Barco BarcoMediano2 = new Barco();
            BarcoMediano2.PosicionDelBarco = Posicion1;

            Barco BarcoRegular1 = new Barco();
            BarcoRegular1.PosicionDelBarco = Posicion1;

            Barco BarcoRegular2 = new Barco();
            BarcoRegular2.PosicionDelBarco = Posicion1;

            Barco BarcoPequeño1 = new Barco();
            BarcoPequeño1.PosicionDelBarco = Posicion1;

            Barco BarcoPequeño2 = new Barco();
            BarcoPequeño2.PosicionDelBarco = Posicion1;

            Barco BarcoPequeño3 = new Barco();
            BarcoPequeño3.PosicionDelBarco = Posicion1;




            int[,] TableroDelJugador = new int[10, 10];

            TableroDelJugador[0, 0] = 1;
            TableroDelJugador[1, 0] = 2;
            TableroDelJugador[2, 0] = 3;
            TableroDelJugador[3, 0] = 4;
            TableroDelJugador[4, 0] = 5;
            TableroDelJugador[5, 0] = 6;
            TableroDelJugador[6, 0] = 7;
            TableroDelJugador[7, 0] = 8;
            TableroDelJugador[8, 0] = 9;
            TableroDelJugador[9, 0] = 10;

            TableroDelJugador[0, 0] = 11;
            TableroDelJugador[0, 1] = 12;
            TableroDelJugador[0, 2] = 13;
            TableroDelJugador[0, 3] = 14;
            TableroDelJugador[0, 4] = 15;
            TableroDelJugador[0, 5] = 16;
            TableroDelJugador[0, 6] = 17;
            TableroDelJugador[0, 7] = 18;
            TableroDelJugador[0, 8] = 19;
            TableroDelJugador[0, 9] = 20;


            /*for (int i = 0; i < 10; i++)
            {
                for (int j=0; j<10; j++)
                {
                    Console.WriteLine("[{0},{1}] = {2}", i, j, TableroDelJugador[i, j]);
                }
            }*/
            Console.ReadKey();



        }
    }
}
