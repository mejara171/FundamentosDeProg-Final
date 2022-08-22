using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            char op;
            double num1, num2;


            Console.WriteLine("Ingrese dos numberos uno por uno");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Ingrese el operador (+, -, *, ?)");
            op = Console.ReadLine()[0];


            switch ( op)
            {
                case '+':
                    Console.Write("{0} + {1}={2}", num1, num2, (num1+num2));
                    break;

                case '-':
                    Console.Write("{0} - {1}={2}", num1, num2, (num1 - num2));
                    break;

                case '*':
                    Console.Write("{0} * {1}={2}", num1, num2, (num1 * num2));
                    break;

                case '/':
                    if (num2 == 0.0)
                        Console.WriteLine("No se puede dividir una cantidad por 0");
                    else
                        Console.Write("{0} / {1}={2}", num1, num2, (num1 / num2));
                    break;



                default:
                    Console.WriteLine("{0} no es un operador valido", op);
                    break; 
            }

        }
    }
}
