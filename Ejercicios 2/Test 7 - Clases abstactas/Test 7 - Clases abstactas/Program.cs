using System;

namespace Test_7___Clases_abstactas
{
    class Program
    {
        static void Main(string[] args)
        {

            ClassClientesBase cliente = new ClassClientesConContacto(0, "Valeria Carpio", "1492",
                "NIT", 1, "Martin Zuluaga", "3217828315", " ", "vqueenc@gmail.com", "cir 3", "68C"
                , "22", "San Joaquin", "Medellin", "Antioquia", "050031" );


            ClassImpresion Impresion;
            Impresion = new ClassImpresion();

            Impresion.ImprimirCliente(cliente);
            
        }
    }
}
