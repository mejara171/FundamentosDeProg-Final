using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
Como parte de las pruebas de concepto para implementar una nueva aplicación de póker (si, otra más),
se te ha encargado que crees un programa en C# que esté en capacidad de indicar si tres cartas conforman
un trío.
Las cartas están codificadas de la siguiente forma:
VT
Donde P corresponde a la pinta y V corresponde al valor. Para las pintas, se utiliza un carácter que puede
ser: (C)orazón, (D)iamante, (P)icas y(T)rébol.Para los valores, se utilizan un carácter que puede ser: A, 2,
3, 4, 5, 6, 7, 8, 9, D, J, Q, K.Aunque en las cartas reales no existe la carta “D”, se utilizará para reemplazar
el “10”. Entonces, una carta DD corresponde al 10 de Diamantes.
El programa pedirá que se ingresen 3 cartas, las cuales deben validarse si corresponden a combinaciones
válidas de cartas. Por ejemplo, 8T si es válida porque corresponde al ocho de trébol, pero T8 no es válida
porque tiene mezclado los valores para cada parte de la carta. Si la carta no es válida, debe solicitarse que
se ingrese nuevamente hasta que las tres correspondan a cartas válidas según la definición previa.
Una vez se hayan ingresado las tres cartas, se verifica si corresponden a un trío, es decir, las tres cartas
tienen el mismo valor, pero tienen pintas distintas. Ej, 3D – 3T – 3P es un trío porque tienen el mismo
valor, pero de pintas distintas.
Es posible que se hayan ingresado cartas repetidas, es decir que dos o más cartas sean iguales. Ej: 4C – 4C
– 5P.En este caso se debe indicar que se hizo trampa porque las cartas no son únicas.
*/

namespace Simulacro_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Identifidor de tríos de Poker");
            Console.WriteLine("El formato es el siguiente: Corazón: C, Diamante: D, Picas: P y Trebol: T");
            Console.WriteLine("Para los valores es: A, 2, 3, 4, 5, 6, 7, 8, 9, D, J, Q, K");
            Console.WriteLine("Tiene que ingresar la carta de la manera: NP, siendo N el valor y P la Pinta");

            int TotalCards = 0;
            bool ValidCard = false;
            string[] EnterCards = new string[3];
            String Card;

            while (TotalCards < 3)
            {
                Console.Write($"Ingrese el valor de la {TotalCards + 1} carta:");
                Card = Console.ReadLine().ToUpper();

                ValidCard = ValidCardMatrix(Card);


                if (ValidCard)
                {
                    EnterCards[TotalCards] = Card;
                    TotalCards++;
                }
                else
                    Console.Write($"La carta {Card} es invalida");

                

            }

            string CheatCard = ValidateCheat(EnterCards);

            if (CheatCard != "Sin trampa")
            {
                Console.WriteLine($"Ingresaste dos cartas o más iguales, intenta de nuevo");
            }

            else
            {
                Console.WriteLine("Todo bien, no hiciste trampa");

                bool Trio = ValidateTrio(EnterCards);

                if(Trio)
                
                    Console.WriteLine("Hay un trío");

                    else
                        Console.WriteLine("No hay trío");

                
            } 

        }

        static bool ValidCardMatrix(string CardDate)
        {

            bool result = false;

            string[] pintas = { "C", "D", "P", "T" };
            string[] value = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "D", "J", "Q", "K" };

            string[,] CardsMaze = new string[value.Length, pintas.Length];

            for (int v = 0; v < value.Length; v++)
                for (int p = 0; p < pintas.Length; p++)

                    CardsMaze[v, p] = value[v] + pintas[p];

            for (int v = 0; v < value.Length; v++)
                for (int p = 0; p < pintas.Length; p++)
                    if (CardsMaze[v, p] == CardDate)
                        result = true;



           return result;
        }


        static string ValidateCheat (string [] CardsArray)
        {
            string result = "Sin trampa";

            for (int i=0; i <CardsArray.Length - 1; i++)
            {
               if (CardsArray[i] == CardsArray [i + 1])
                {
                    result = CardsArray[i];
                    break;
                }
            }

            if (CardsArray[0] == CardsArray[CardsArray.Length - 1])
                result = CardsArray[0];

            return result;

        }


        static bool ValidateTrio(string[] CardsArray)
        {
            bool result = false;
            int SameData = 0;




            for (int i = 0; i < CardsArray.Length - 1; i++)

                if (CardsArray[i].Substring(0, 1) == CardsArray[i + 1].Substring(0, 1))
                    SameData++;

            if (SameData == 2)
                result = true;


            return result;
        }
    }
}
