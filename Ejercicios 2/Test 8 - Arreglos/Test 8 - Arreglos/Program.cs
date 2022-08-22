using System;

namespace Test_8___Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {

            String Cadenas = Console.ReadLine();
            int n = Convert.ToInt32(Cadenas);


            int[] Arreglo = new int[12];
            int i;

            for (i = 0; i < 12; i++)
            {
                Arreglo[i] = i + n;
            }

            for (i = 0; i < 12; i++)
            {
                Console.WriteLine("{0}", Arreglo[i]);
            }

            Console.ReadKey();
        }
    }
}
