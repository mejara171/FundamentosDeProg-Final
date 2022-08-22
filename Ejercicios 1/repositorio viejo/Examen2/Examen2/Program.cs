
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular el promedio de ventas en ciudades \n");
            Console.WriteLine("Se ingresarán la cantidad de ciudades que se quieran evaluar. Cada ciudad tendrá su número único");
            Console.WriteLine("Luego se ingresarán el total de ventas por ciudad");
            Console.WriteLine("Por consiguiente, se ingresarán el total de ventas por mes, siendo enero(1) y diciembre(12)");
            Console.WriteLine("Luego se ingresarán el total de ventas por Consolas, siendo Xbox One (1), Playstation 4 (2) y Nintendo Switch (3) \n");



            int numberOfSales = 0;
            int Meses = 12;
            int Consolas = 3;
            double[] sales;
            double[] SalesMeses;
            double[] SalesConsolas;





            Console.Write("Ingrese el número de ciudades \n");
            numberOfSales = Convert.ToInt32(Console.ReadLine());


            sales = new double[numberOfSales];


            for (int i = 0; i < numberOfSales; i++)
            {
                Console.Write("Ingrese las ventas para la ciudad #{0}: ", i + 1);
                sales[i] = Convert.ToDouble(Console.ReadLine());
            }
            double sum = sales.Sum();
            for (int i = 0; i < numberOfSales; i++)
            {
                double contribution = sales[i] / sum;
                Console.WriteLine("Ventas de la ciudad # {0} fueron {1:C2} y contribuyeron {2:P2}", i + 1, sales[i], contribution);
            }
            Console.WriteLine("La suma total de ventas es {0:C2}", sum);


            SalesMeses = new double[Meses];


            for (int i = 0; i < Meses; i++)
            {
                    Console.Write("Ingrese las ventas del mes #{0}: ", i + 1);
                    SalesMeses[i] = Convert.ToDouble(Console.ReadLine());
            }

            double MesesSum = SalesMeses.Sum();
            for (int i = 0; i < Meses; i++)
            {
                double contribution = SalesMeses[i] / sum;
                Console.WriteLine("Ventas del mes # {0} fueron {1:C2} y contribuyeron {2:P2}", i + 1, SalesMeses[i], contribution);
            }
            Console.WriteLine("La suma total de ventas es {0:C2}", sum);


            SalesConsolas = new double[Consolas];

            for (int i = 0; i < Consolas; i++)
            {
                Console.Write("Ingrese las ventas en de la consola #{0}:\n", i + 1);
                SalesConsolas[i] = Convert.ToDouble(Console.ReadLine());
            }
            
            double Sum = SalesConsolas.Sum();
            for (int i = 0; i < Consolas; i++)
            {
                double contribution = SalesConsolas[i] / sum;
                Console.WriteLine("Ventas de la consola # {0} fueron {1:C2} y contribuyeron {2:P2}", i + 1, SalesConsolas[i], contribution);
            }
            Console.WriteLine("La suma total de ventas es {0:C2}", sum);

        }
    }
}