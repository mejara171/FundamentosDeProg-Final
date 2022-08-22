using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test_6___Herencia
{
    class ClienteProgram
    {
        static void Main(string[] args)
        {
            //se declara la clase clientes
            ClassClientes Cliente;

            Cliente = new ClassClientes();

            //se crea una un camino donde se almacenara la información del cliente, en este caso, se usa un txt para almacenar 
            string filePath = @"C:\Users\juanj\source\repos\AppTienda\AppTienda\data.txt";

            //Se declara una lista que leerá la información
            List<string> lines = File.ReadAllLines(filePath).ToList();

            //Se hace un foreach para que cada vez que se ingrese información, cree una linea
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }

            //se pregunta al usuario la información del cliente
            Console.WriteLine("Ingrese el id del cliente");
            Cliente.IdCliente = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los apellidos del cliente");
            Cliente.Apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese los nombres del cliente");
            Cliente.Nombres = Console.ReadLine();
            Console.WriteLine("Ingrese la CC del cliente");
            Cliente.CC = Console.ReadLine();
            Console.WriteLine("Ingrese la dirección del cliente");
            Cliente.Direccion = Console.ReadLine();
            Console.WriteLine("Ingrese el municipio del cliente");
            Cliente.Municipio = Console.ReadLine();
            Console.WriteLine("El cliente tiene crédito? responda con true or false");
            Cliente.EsCredito = bool.Parse(Console.ReadLine());

            //se agrega esta información como un line
            lines.Add(Cliente.Apellidos);
            lines.Add(Cliente.Nombres);
            lines.Add(Cliente.CC);
            lines.Add(Cliente.Direccion);
            lines.Add(Cliente.Municipio);
            lines.Add("----------------");

            //se destina la información a la base de datos
            File.WriteAllLines(filePath, lines);







            //se escribe la información del cliente en el programa tal cual la digito el usuario
            Console.WriteLine(Cliente.Apellidos + " " + Cliente.Nombres);
            Console.WriteLine(Cliente.Direccion + ", "  + Cliente.Municipio);
            Console.WriteLine(Cliente.CC);

            //se crea una condicional para informar si el cliente tiene linea de credito o no 
            if(Cliente.EsCredito)
            {
                Console.WriteLine("El cliente tiene credito");
                Cliente.EsCredito = true;
            }
            else
            {
                Console.WriteLine("El cliente no tiene credito");
                Cliente.EsCredito = false;
            }


            //se agrega un readkey para que el programa no se finalice luego de ejecutar los procesos 
            Console.ReadKey();
        }
    }
}
