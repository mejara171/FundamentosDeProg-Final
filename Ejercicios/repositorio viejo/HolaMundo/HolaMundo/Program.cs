using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detector de situaciones en pandemia");
            Console.WriteLine("\nIngrese la calificación para cada domicilio");
            Console.WriteLine("(A)limentación, (D)ocumentos, (L)icores y (M)edicamentos");

            int totalA = 0, totalD = 0, totalL = 0, totalM = 0;
            int totalAcciones = 1;
            string evaluacion = "";

            while (totalAcciones <= 20)
            {
                Console.Write("Ingrese la calificación para el domiclio {0}: ", totalAcciones);
                evaluacion = Console.ReadLine().ToUpper();

                if (evaluacion == "A" || evaluacion == "D" || evaluacion == "L" || evaluacion == "M")
                {
                    if (evaluacion == "A")
                        totalA++;

                    if (evaluacion == "D")
                        totalD++;

                    if (evaluacion == "L")
                        totalL++;

                    if (evaluacion == "M")
                        totalM++;

                    totalAcciones++;
                }
                else
                {
                    Console.WriteLine("Ingresa un valor correcto \n\n");
                }
            }



            Console.WriteLine("\n\nResultados de los domicilios:");
            Console.WriteLine("Alimentos: {0}", totalA);
            Console.WriteLine("Documentos: {0}", totalD);
            Console.WriteLine("Licores: {0}", totalL);
            Console.WriteLine("Medicamentos: {0}", totalM);
            Console.WriteLine("Total: {0}\n", (totalA + totalD + totalL + totalM));




            if (totalL > totalD &&
                totalL > totalM &&
                totalL > totalA) 
                Console.WriteLine("Llame inmediatamente a la policía, hay una fiesta en el lugar");
            else
                if ((totalA + totalM) > 12)
                Console.WriteLine("Un día normal, siga disfrutando de su labor");
            else
                if ((totalM) > (totalA + totalD)) 
                Console.WriteLine("Algo raro está sucediendo, contacte con las autoridades");
        }
    }
}
