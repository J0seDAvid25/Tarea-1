using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion1
{
    class Program
    {
        static string cliente = "";
        static int telefono;
        static int cantidad;
        //static int descuento_total= 20;//
        static int montorecibo;
        static int montocambio;
        static int precios;
        
        static int TotalOrden ;
        static float ImpuestoVenta = 13;
        static int PrecioNeto = TotalOrden;
        static int montopagado;
        static double seleccion = TotalOrden - TotalOrden/ 1.5;


        static void Main(string[] args)
        {
            Console.Write("Digite el nombre del cliente\n");
            cliente = Console.ReadLine();
            Console.Write("Digite el numero telefono \n");
            telefono = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                  Console.Write("\n Menu de opciones de libros a escoger o comprar \n" +
                "\n 1.- El Señor de los anillos, Las dos Torres" +
                "\n 2.- Alicia en el país de Maravillas" +
                "\n 3.- Cementerio de Mascotas" +
                "\n 4.- Quiero aprender" +
                "\n 5.- El poder del pensamiento Positivo" +
                "\n 6.- Mi primer libro de matemáticas" +
                "\n 7.- Las aventuras de Tom Sawyer" +
                "\n 8.- El mago de Oz" +
                "\n 9.- La zona muerta" +
                "\n 10.- Viaje al centro de la tierra" +
                "\n 11.-SALIR\n");

            int s1 = 0;
            s1 = Convert.ToInt16(Console.ReadLine());


            switch (s1)
            {

                case 1:
                    Console.WriteLine("\n Ha elegido el libro El señor de los anillos, las dos torres \n");
                    break;

                case 2:
                    Console.WriteLine("\n Ha elegido el libro Alicia en el país de la Maravillas \n");
                    break;

                case 3:
                    Console.WriteLine("\n Ha elegido el libro Cementerio de Mascotas \n");
                    break;

                case 4:
                    Console.WriteLine("\n Ha elegido el libro Quiero aprender \n");
                    break;

                case 5:
                    Console.WriteLine("\n Ha elegido el libro El poder del pensamiento Positivo \n");
                    break;
                case 6:
                    Console.WriteLine("\n Ha elegido el libro Mi primer libro de matemáticas \n");
                    break;
                case 7:
                    Console.WriteLine("\n Ha elegido el libro Las aventuras de Tom Sawyer \n");
                    break;
                case 8:
                    Console.WriteLine("\n Ha elegido el libro El mago de Oz \n");
                    break;
                case 9:
                    Console.WriteLine("\n Ha elegido el libro La zona muerta \n");
                    break;
                case 10:
                    Console.WriteLine("\n Ha elegido el libro Viaje al centro de la tierra \n");
                    break;
                case 11:
                    Console.WriteLine("\n Ha elegido salir \n");
                    break;

                default:
                    Console.WriteLine("\n No ha seleccionado nada");
                    break;
                                                
            }                
            Console.WriteLine("Digite precio del libro a comprar ");

            precios = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite la cantidad de libros a comprar");
            cantidad = Convert.ToInt16(Console.ReadLine());

            montorecibo = cantidad * precios;
            Console.WriteLine("El monto a pagar es " + montorecibo);

            Console.WriteLine("Digite el monto con el que va a pagar");
            montopagado = int.Parse(Console.ReadLine());
            montocambio = montorecibo - montopagado;
            Console.WriteLine("El cambio es de " + montocambio);
            Console.WriteLine("El descuento para su libro es del 5% al 25%");    
            montorecibo = PrecioNeto;
            PrecioNeto = montopagado * 10;
            TotalOrden = precios * cantidad;
            
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            

            Console.WriteLine(" Creacion de factura");
            Console.WriteLine("================================================================================================================");
            Console.WriteLine("*-*                                           **Libreria El Buen Lector**                       *-*");
            Console.WriteLine("================================================================================================================");
            Console.WriteLine("Cliente: " + cliente);
            Console.WriteLine("Telefono: " + telefono);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|Item|                        |Cantidad|                    |Precios|                               |Subtotal \n");
            Console.WriteLine("\n Libro 1........................." + cantidad++ + "............................." + precios + "......................................" + "0.00");
            Console.WriteLine("\n Libro 2........................." + cantidad++ + "............................." + precios*2 + "......................................" + "0.00");
            Console.WriteLine("\n Libro 3........................." + cantidad++ + "............................." + precios*2.5 + "....................................." + "0.00");                                   
            Console.Write("\n----------------------------------------------------------------------------------------------------------------\n");

            Console.WriteLine("\n Total Orden............................................................................................."+ TotalOrden,"\n");
            Console.WriteLine("\n Descuento total .........................................................................................20% \n");
            Console.WriteLine("\n Impuesto Venta...........................................................................................13% \n");
            Console.WriteLine("\n Impuesto total..........................................................................................0.00\n");
            Console.WriteLine("\n Precio Neto............................................................................................"+ TotalOrden/1.5, "\n");

            Console.WriteLine("============================================================================================================= \n");
            
            Console.WriteLine("Monto Recibido: " + TotalOrden / 1.5);
            Console.WriteLine("Monto Cambio:   " , seleccion);

            
            Console.WriteLine("==============================================================================================================\n");
            Console.WriteLine("Gracias por su compra");
            Console.WriteLine("------------------Que tenga buen dia---------------------");
            Console.WriteLine("==============================================================================================================\n");
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
