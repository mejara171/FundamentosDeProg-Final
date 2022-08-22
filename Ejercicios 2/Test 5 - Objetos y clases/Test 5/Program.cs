using System;

namespace Test_5
{
    class Program
    {
        static void Main(string[] args)
        {

            classEmpleados empleado;
            empleado = new classEmpleados();

            empleado.Edad = 25;
            empleado.Nombre = "Valeria Carpio";
            empleado.SueldoDiario = 12.5m;

            decimal total;
            total = empleado.CalculaSalario(30);

            Console.WriteLine("el salario mensual del empleado " + empleado.Nombre);
            Console.WriteLine("es: " + total.ToString());
            Console.ReadKey();
        }
    }
}
