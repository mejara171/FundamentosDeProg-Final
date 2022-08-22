using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Test_9___ArrayList
{
    class ClassMuestraHashTable
    {
        Hashtable Tabla;
        
        public ClassMuestraHashTable()
        {
            Tabla = new Hashtable();
        }

        public void AgregarDatos()
        {
            Tabla.Add("C001", "Producto 1");
            Tabla.Add("C002", "Producto 3");
            Tabla.Add("C003", "Producto 3");
            Tabla.Add("C004", "Producto 4");
        }

        public void ImprimirDatos()
        {
            Console.WriteLine("Existen {0} elementos, dame la clave del producto: ", Tabla.Count);
            string cadena = Console.ReadLine();
            if(Tabla[cadena] == null)
            {
                Console.WriteLine("El elemento no existe");
            }

            else
            {
                Console.WriteLine("El elemento encontrado es: ");
                Console.WriteLine(Tabla[cadena]);
            }

            Console.ReadKey();
        }


        public void EliminarElemento(string key)
        {
            Tabla.Remove(key);
        }
    }
}
