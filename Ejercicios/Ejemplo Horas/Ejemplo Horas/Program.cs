using System;

namespace Ejemplo_Horas
{


    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca una hora, por favor");
            int hora; 


            try
            {
                hora = Int32.Parse(Console.ReadLine());
                if (hora >= 5 && hora < 12)
                {
                    Console.WriteLine("Buenos días");
                }
                else if (hora >= 12 && hora < 16)
                {
                    Console.WriteLine("Buenas tardes");
                }
                else if (hora >= 16 && hora < 5)
                {
                    Console.WriteLine("Buenas noches");
                }
                else
                {
                    Console.WriteLine("Número fuera del rango");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Has introducido un formato no aceptado");
            }         

        }
    }
}
