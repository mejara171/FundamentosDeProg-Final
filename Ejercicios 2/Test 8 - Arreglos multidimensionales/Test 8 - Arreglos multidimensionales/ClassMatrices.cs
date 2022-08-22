using System;
using System.Collections.Generic;
using System.Text;

namespace Test_8___Arreglos_multidimensionales
{
    class ClassMatrices
    {
        private int[,] Matriz;

        public ClassMatrices()
        {
            Matriz = new int [4, 2];
        }


        public void InicializaMatriz()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Matriz[i, j] = 1;
                }
            }
        }

        public void ImprimeMatriz()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0} ", Matriz[i, j]);
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
