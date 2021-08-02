using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePractica3007
{
    class Ejercicio1
    {
        //declaracion de ENUM
        //Constantes
        public enum Dias
        {
            LUNES,
            MARTES,
            MIERCOLES,
            JUEVES,
            VIERNES,
            SABADO,
            DOMINGO
        }
        static void Main(string[] args)
        {
            //ENUM
            //Clase especial, representa un conjunto de constantes
            Console.WriteLine("Escriba correspondiente al dia de la semana");
            //int dia = Convert.ToInt32(Console.ReadLine()); //Convert. se utiliza para convertir tipos de datos strean a entero.
            int dia = int.Parse(Console.ReadLine()); //Realiza un tipo de conversion


            switch (dia)
            {
                case 1:
                    Console.WriteLine(Dias.LUNES);
                    break;
                case 2:
                    Console.WriteLine(Dias.MARTES);
                    break;
                case 3:
                    Console.WriteLine(Dias.MIERCOLES);
                    break;
                case 4:
                    Console.WriteLine(Dias.JUEVES);
                    break;
                case 5:
                    Console.WriteLine(Dias.VIERNES);
                    break;
                case 6:
                    Console.WriteLine(Dias.SABADO);
                    break;
                case 7:
                    Console.WriteLine(Dias.DOMINGO);
                    break;

            }

            Console.ReadKey();

        }
    }
}
