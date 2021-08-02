// Referencia hacia los espacios de nombres del .NET Framework
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseTeorica2907 //nombre del espacio de nombre
{
    class TipoDatos //nombre de la clase
    {
        static void Main(string[] args) //metodo principal
        {
            /*Console.WriteLine("Esta es la clase variables");
            Console.ReadKey();*/

            //VARIABLES
            //tipos de datos 

            //almacena 1| byte
            byte num1 = 255;

            //variante de byte
            //solo almacena numeros negativos
            sbyte num2 = -127;

            //int, soporta negativos y positivos, 4 bytes disponibles
            int num3 = 22;
            int num4 = -20;

            //uint, solamente adminte numeros positivos
            uint num5 = 28;

            //long permite almacenar mas datos
            //Para procesar millones de datos
            long num6 = -158;
            long num7 = 20000;

                
            ulong num8 = 2222222222; //solo admite numeros positivos


            //procesamiento de decimales
            //float, se debe especificar una f, 4 bytes
            float num9 = 100.9f;

            //double, tiene mas alcence, 8 bytes
            double num10 = 100.9d;

            //decimal , 16 bytes
            decimal num11 = 100.9m;

            //Guardar cadena de caracter, solo permite 2 bytes
            char caracter = 'A'; //se cierra en comillas simples

            // string
            string texto = "Programacion Computacional I";

            //Variable de tipo implicito
            //var, para  declarar cualquier tipo datos integrado o un tipo definido
            

            Console.WriteLine("Cual es su Nombre");
            var nombre = Console.ReadLine(); //Captura lo que el usuario escribe por teclado
            var cantidad = 100.50d;

            Console.WriteLine("El tipo de datos para la variable nombre es {0}", nombre.GetType());
            Console.WriteLine("El tipo de datos para la variable nombre es {0}", cantidad.GetType());
            Console.ReadKey();






        }
    }
}
