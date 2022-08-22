using System;

namespace Holamundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo!");
            Console.WriteLine("Escribe 1 o 2 dependiendo del camino que quieras escoger");

            int valor1 = 0;
            string cadena;

            cadena = Console.ReadLine();
            valor1 = Convert.ToInt32(cadena);

            if (valor1==1)
            {
                Console.WriteLine("Osorio es un malparido por ponernos a trabajar en un día de descanso en una materia que no nos aporta en nada al desarrollo profesional de nuestra carrera");
            }
            else
            {
                Console.WriteLine("Osorio es una buena persona por ser responsable con el trabajo de Taller IV ya que es una materia que nos costó a cada uno 1,500,000  y por lo tanto, tenemos que cumplirla de manera adecuada "); 
            }

            Console.ReadKey();
        }
    }
}
