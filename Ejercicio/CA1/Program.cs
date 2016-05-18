using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Program
    {
        static string name = "";
        static int month = 0;
        static int Main()
        {
                   
            Console.WriteLine("Hola Estudiantes");

            Console.Write("Digite si nombre : ");

            name = Console.ReadLine();

            Console.WriteLine("Buenas Tardes " + name);

            Console.Write("Digite su mes de nacimiento " );

            month = int.Parse(Console.ReadLine());

            month = Convert.ToInt16((Console.ReadLine()));

            if (month == 8)
            {
                Console.WriteLine("ERES virgo");
            }
            else
            {
                Console.WriteLine("No tengo informacion");
            
            }
            if (month == 1)
            {
                Console.WriteLine("Es Acuario");
            }else if (month ==2){

                Console.WriteLine("Es Piscis");
            }
            else if (month == 3)
            {
                Console.WriteLine("Es Aries");
            }
            else if (month == 4)
            {
                Console.WriteLine("Es Tauro");
            }
            else if (month == 5)
            {
                Console.WriteLine("Es Geminis");
            }
            else if (month == 6)
            {
                Console.WriteLine("Es Cancer");
            }
            else if (month == 7)
            {
                Console.WriteLine("Es leo");
            }

            else if (month == 9)
            {
                Console.WriteLine("Es libra");
            }
            else if (month == 10)
            {
                Console.WriteLine("Es Escorpio");
            }
            else if (month == 11)
            {
                Console.WriteLine("Es Sagitario");
            }
            else if (month == 12)
            {
                Console.WriteLine("Es Capricornio");
            }
            Console.ReadKey();
            return  0;


        }
    }
}
