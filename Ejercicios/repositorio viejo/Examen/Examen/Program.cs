using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {

        static void Main(string[] args)
            {
                Console.WriteLine("Control de Importaciones planetarias");
                Console.WriteLine("Ingrese un tipo de nave entre Pasajeros (P), Minería (M), Alimentos (M)");
                Console.WriteLine("Tiene que suministrar un valor numérico para el peso de las naves (Toneladas)\n");
      



                int TotalNaves = 0;
                float TotalNaves2 = TotalNaves;
                string nave = "";
                float PesoNave = 0;
            bool Verificación;




            float[] totalesCarga = new float[3];

                int[] CantidadNaves = new int[3];



                for (int i = 0; i < 3; i++)
                {
                    totalesCarga[i] = 0;
                    CantidadNaves[i] = 0;
                }

            Verificación = false;
            while (Verificación == false)
            {
                try
                {
                Console.WriteLine("\nCantidad de naves a registrar");
                TotalNaves2 = float.Parse(Console.ReadLine());


                    if (TotalNaves2 > 0)
                        Verificación = true;
                    else
                        Console.WriteLine("Debe ser un dato numérico");
                }
                catch (FormatException error)
                {
                    Console.WriteLine("Debe ser un dato numérico");
                }
            }




            while (TotalNaves < TotalNaves2)
                {
                    Console.Write("\nIngresa el tipo de nave {0} (P,M,A): ", TotalNaves + 1);
                    nave = Console.ReadLine().ToUpper();


                    if (nave == "P" || nave == "M" || nave == "A")
                    {
                        try
                        {

                            Console.Write("Ingresa el valor del cargamento (Toneladas): ");
                            PesoNave = float.Parse(Console.ReadLine());

                            if (PesoNave >= 0 && PesoNave <= 100000000000)
                            {

                                switch (nave)
                                {
                                    case "P":
                                        CantidadNaves[0]++;
                                        totalesCarga[0] += PesoNave;
                                        break;

                                    case "M":
                                        CantidadNaves[1]++;
                                        totalesCarga[1] += PesoNave;
                                        break;

                                    case "A":
                                        CantidadNaves[2]++;
                                        totalesCarga[2] += PesoNave;
                                        break;
                                }


                                TotalNaves++;
                            }
                            else
                            {
                                Console.WriteLine("Ingresa un valor de peso valido \n");
                            }
                        }
                        catch (FormatException error)
                        {
                            Console.WriteLine("Ingresa un valor de peso valido");
                            Console.WriteLine("Error: {0} \n", error.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingresaste un tipo de nave invalido \n");
                    }
                }


                float[] promedio = PromedioNaves(CantidadNaves, totalesCarga);


                Console.WriteLine("\n\nResultados del proceso Importanciones:\n");

                Console.Write("\nTipo de naves: \tP \tM \tA");
                Console.Write("\nEntradas: \t");
                for (int i = 0; i < 3; i++)
                    Console.Write(CantidadNaves[i] + "\t");

                Console.Write("\nTotal Carga: \t");
                for (int i = 0; i < 3; i++)
                    Console.Write(totalesCarga[i] + "\t");

                Console.Write("\nPromedio: \t");
                for (int i = 0; i < 3; i++)
                    Console.Write(promedio[i] + "\t");

                Console.WriteLine();

            }



            static float[] PromedioNaves(int[] AjusteNaves, float[] AjusteCarga)
            {
                float[] promedio = new float[3];


                for (int i = 0; i < promedio.Length; i++)
                {

                    if (AjusteNaves[i] == 0)
                        promedio[i] = 0;
                    else
                        promedio[i] = AjusteCarga[i] / AjusteNaves[i];
                }
                return promedio;
            }
        }
    }