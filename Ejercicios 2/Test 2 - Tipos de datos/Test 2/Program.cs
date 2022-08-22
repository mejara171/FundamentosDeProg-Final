using System;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            //para números enteros 

            decimal x = 0.0m;
            //para números con decimales y pocos digitos

            float f = 0.0f;
            //Para números con decimales, con buena precisión

            double d = 0.0D;
            //Para números con decimales, con mayor precisión

            string cadena = "Hola mundo";
            //Cadena de caracteres 

            bool bandera = false;
            //Toma dos valores, false y true

            DateTime fecha = DateTime.MinValue;
            //Declara un valor de fecha, a un valor mímimo

            Console.WriteLine("El valor de i es: {0}", i);
            //Toma el string {0} de la variable i 
            Console.WriteLine("El valor de X es: {0:C}", x);
            //C es currency, devuelve el dato como formato Currency 
            Console.WriteLine("El valor de f es: {0;F2}", f);
            Console.WriteLine("El valor de d es: {0;F2}", d);
            // Convierte la variable a formato punto fijo 
            Console.Write("El valor de cadena es: " + cadena);
            // Devuelve la cadena 
            Console.WriteLine("El valor de bandera es: " + bandera.ToString());
            //El método ToString convierte el dato en cadena 
            Console.Write("El valor de fecha es: " + fecha.ToShortDateString());
            //Convierte el dato de fecha corta en cadena 
            Console.ReadKey();

        }
    }
}
