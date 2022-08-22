using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Test_9___ArrayList
{
    class ClassMostrarArrayList
    {
        ArrayList Lista;


        public ClassMostrarArrayList()
        {
            Lista = new ArrayList();
        }

        public void CapturaDatos()
        {
            string cadena;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Dame el dato {0}", i + 1);
                cadena = Console.ReadLine();
                Lista.Add(cadena);
            }


        }
        public void ImprimeDatos()
        {
            foreach (var item in Lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
