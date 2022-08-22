using System;
using System.Linq;


namespace Actividad___Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {

        


            int[] Arreglo = new int[200];
            int i, n, sum = 0;
            decimal avg = 0;



            Console.Write("Ingrese el número a de elementos para almacenar en el arreglo: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A continuación, los números pares de la longitud del arreglo");

            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "");
                }
            }

            Console.WriteLine("A continuación, la suma de todos los elementos en el arreglo");

            for (i = 1; i <= n; i++)
            {
                Arreglo[i] = i + n;
                sum += i;
            }

            Console.WriteLine(sum);

            Console.WriteLine("A continuación, el promedio de todos los elementos del arreglo");

             avg = (sum / n)+(0.5m);

            Console.WriteLine(avg);

            Console.WriteLine("A continuación, el arreglo con los datos en orden inverso");


            for (i = 0; i < n; i++)
            {
                Arreglo[i] = n -i;
                Console.WriteLine("{0}", Arreglo[i]);
            }




        }
  

    }
}
