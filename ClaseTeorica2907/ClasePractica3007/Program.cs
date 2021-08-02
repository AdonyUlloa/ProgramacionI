using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica3007
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores
            string nombre = "jose";
            string saludo = "Bienvenido";
            int a = 10;
            int b = 20;



            //Console.WriteLine(saludo + nombre);



            //if (a < b) // Operador de comparacion, menor que
            /*{
                Console.WriteLine("a es menor que b");
            }
            else if (a > b)
            {
                Console.WriteLine("a es mayor que a b");
            }
            else
            {
                Console.WriteLine("a y b son iguales");

            }*/

            //If anidados

            if (a != b) //Operador de compareacion, difrente de
            {
                if (a < b)
                {
                    Console.WriteLine("a es menor que b");
                }
                else if (a > b)
                {
                    Console.WriteLine("a es mayot a b");
                }

            }
            else Console.WriteLine("a es igual a b");

            //OPERADOR TERNARIO
            // La forma abreviada de if else

            var resultado = a > b ? "a es mayor a b" : "a es menor que a b";
            Console.WriteLine("Resultado con con operador ternario: {0}", resultado);


            Console.ReadKey();
        }
    }
}
