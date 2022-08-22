using System;

namespace Test_9___ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassMostrarArrayList Muestra = new ClassMostrarArrayList();

            //Muestra.CapturaDatos();
            //Muestra.ImprimeDatos();

            ClassMuestraHashTable MuestraH;
            MuestraH = new ClassMuestraHashTable();
            MuestraH.AgregarDatos();
            MuestraH.ImprimirDatos();
            MuestraH.EliminarElemento("C001");
            MuestraH.ImprimirDatos();
        }
    }
}
