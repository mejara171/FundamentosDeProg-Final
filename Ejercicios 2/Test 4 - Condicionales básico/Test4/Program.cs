using System;

namespace Test4
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0, valor2 = 0;
            string cadena;

            Console.WriteLine("Dame el primer valor");
            cadena = Console.ReadLine();
            valor1 = Convert.ToInt32(cadena);

            Console.WriteLine("Dame el segundo valor");
            cadena = Console.ReadLine();
            valor2 = Convert.ToInt32(cadena);

            if (valor1 <= valor2)
            {
                if (valor1 == valor2)
                {
                    Console.WriteLine("El valor 1 es igual que el valor 2");
                }
                else
                    Console.WriteLine("Valor 2 es mayor o igual al valor 1");
            }

            else
                Console.Write("El valor 1 es mayor que el valor 2"); 


            Console.ReadKey();

        }
    }
}
