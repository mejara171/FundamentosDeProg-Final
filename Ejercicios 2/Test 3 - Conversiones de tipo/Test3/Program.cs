using System;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            decimal x = 12.2m;
            bool bandera = false;
            string cadena = string.Empty;
            //Cadena vacía 
            DateTime fecha = DateTime.MinValue;

            i = (int)x;
            //Cast de variable decimal a entero, conversión explicita
            //Se puede convertir una variable de menor exactitud en una de mayor exactitud, pero no visceversa. 

            i = Convert.ToInt32(X);
            //Conversión por medio de objeto convert, de decimal a entero. Si se usa este método en un booleano, si es true devuelve 1 y false devuelve 0. 
            // Si se usa en una cadena, si tiene caracteres alfabéticos, dará error, pero si tiene caracteres numéricos, los convertirá. 


            Console.WriteLine("El valor de i es: {0}", i);
            Console.WriteLine("El valor de x es: {0}", x);
            Console.WriteLine("El valor de bandera es: " + bandera.ToString());
            Console.WriteLine("El vlaor de cadena: " + cadena);
            Console.WriteLine("El valor de fecha: " + fecha.ToShortDateString());
            Console.ReadKey();



        }
    }
}
