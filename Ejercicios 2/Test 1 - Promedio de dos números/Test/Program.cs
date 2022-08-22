using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1, m2;

            Console.WriteLine("Ingrese dos números, el primero siendo menor que el segundo");
            n1 = int.Parse(Console.ReadLine());
            m2 = int.Parse(Console.ReadLine());

            if (n1<m2)
            {
                int avg = (n1 + m2) / 2;

                Console.WriteLine("El promedio es " + avg);

            }

            else
            {
                Console.WriteLine("Has introducido valores incorrectos");
            }


        }
    }
}
