using System;

namespace Ejercicios_Cap3

{
    class Program
    {
        static void Main(string[] args)
        {
            //CAPITULO 3


            ////Ejercicio Circunferencia 1

            //double r, a, l;


            //Console.WriteLine("Escriba el radio de la circunferencia");
            //r = double.Parse(Console.ReadLine());


            //if (r>0)
            //{
            //    a = r*r*(Math.PI);
            //    l = r * 2 * (Math.PI);

            //    Console.WriteLine("El area de la circunferencia es {0}", a);
            //    Console.WriteLine("La longitud de la circunferencia es {0}", l);
            //}

            //Console.ReadKey();





            ////Ejercicio edades 2

            //int Samuel, Ana, Abuelo, Samuel2;
            //Console.WriteLine("Ingrese la edad de Samuel");
            //Samuel = int.Parse(Console.ReadLine());

            //if (Samuel > 0)
            //{
            //    Ana = Samuel + 39;
            //    Abuelo = Ana + 29;
            //    Samuel2 = Samuel + 10;

            //    Console.WriteLine("La edad de Ana en 10 años es {0}", Ana);
            //    Console.WriteLine("La edad del Abuelo en 10 años es  {0}", Abuelo);
            //    Console.WriteLine("La edad de Samuel en 10 años es  {0}", Samuel2);
            //}

            //Console.ReadKey();




            //Ejercicio números 3

            //int n, n1, n2, n3, sum;

            //Console.WriteLine("Escriba un número de tres cifras");
            //n = int.Parse(Console.ReadLine());


            //n1 = n % 10;
            //n = n / 10;
            //n2 = n % 10;
            //n = n / 10;
            //n3 = n % 10;
            //sum = n1 + n2 + n3;

            //Console.WriteLine("La suma de los digitos es {0}", sum);




            //Ejercicio división 8

            //int a, b; 

            //Console.WriteLine("Ingrese el número a");
            //a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese el número b");
            //b = int.Parse(Console.ReadLine());


            //if (a % b == 0)
            //{
            //    Console.WriteLine("el número a es divisible por b");
            //}

            //else
            //{
            //    Console.WriteLine("el número a no es divisible por b");
            //}



            //CAPITULO 4

            //int numero, n, cDigitos = 0, digito, suma = 0;

            //Console.WriteLine("Digite el número de máximo cuatro cifras");
            //numero = int.Parse(Console.ReadLine());
            //n = numero;
            //digito = n % 10;
            //n = n / 10;
            //cDigitos = cDigitos + 1;
            //suma = suma + digito;


            // if(n>0)
            //{
            //    digito = n % 10;
            //    cDigitos = cDigitos + 1;
            //    n = n / 10;
            //    suma = suma + suma + digito;
            //}
            //if (n > 0)
            //{
            //    digito = n % 10;
            //    n = n / 10;
            //    cDigitos = cDigitos + 1;
            //    suma = suma + digito;

            //}
            //if (n > 0)
            //{
            //    digito = n % 10;
            //    n = n / 10;
            //    cDigitos = cDigitos + 1;
            //    suma = suma + digito;
            //}

            //if (n>0)
            //{
            //    Console.WriteLine("El número tiene más de cuatro cifras");
            //}
            // else
            //{
            //    Console.WriteLine("el número tiene {0}", cDigitos);
            //    Console.WriteLine("La suma de los dígitos es {0}", suma);
            //}



            //CAPITULO 4 EJER  10

            int numero = 0;
            Console.WriteLine("Digite el número sacado de la bolsa");
            numero = int.Parse(Console.ReadLine());

            if (numero == 1)
            {
                Console.WriteLine("Se va a Bogotá");
            }

            else if (numero==2) 
            {
                Console.WriteLine("Se viaja a Barranquilla");
            }

            else if (numero == 3)
            {
                Console.WriteLine("Se viaja a Cartagena");
            }

            else if (numero == 4)
            {
                Console.WriteLine("Se viaja a Cali");
            }


            else
            {
                Console.WriteLine("No se viaja");
            }


            

        }


    }
}
