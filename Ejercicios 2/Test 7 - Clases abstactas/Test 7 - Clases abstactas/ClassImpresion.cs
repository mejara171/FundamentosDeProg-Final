using System;
using System.Collections.Generic;
using System.Text;

namespace Test_7___Clases_abstactas
{
    class ClassImpresion
    {

        public void ImprimirCliente(ClassAbsClientes cliente)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(cliente.Clave + "" + cliente.Nombre);
            if (cliente.TipoRegimen== 1)
            {
                Console.WriteLine("Tipo: PERSONA FISICA");
            }

            else
            {
                Console.WriteLine("Tipo: PERSONA MORAL");
            }
            Console.WriteLine("RFC: " + cliente.RFC);


            Console.ReadKey();
        }

        public void ImprimirDireccion(ClassDirecciones Direccion)
        {

            Console.WriteLine(Direccion.Calle + "No" + Direccion.NumeroExterior);
            Console.WriteLine(Direccion.Colonia);
            Console.WriteLine(Direccion.CP);
            Console.WriteLine(Direccion.Estado);

        }


    }
}
