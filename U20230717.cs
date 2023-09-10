using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //for // foreach

            for (int i = 0; i < 10; i++)
            {
               Console.WriteLine($"El numero {i}");

            } //Fin for */

            //Elaborar tabla de multiplicar de numero N

            Console.WriteLine("\nIngrese un numero para elaborar su tabla de multiplicar");
            int numero=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                int multiplicacion = numero * i;

                Console.WriteLine($"{numero} x {i} = {multiplicacion}");
            }

            //Foreach
            //Declarar una lista

            List<int> numeros = new List<int> {24,10,8,35,14,7};

            int minimo = numeros[0]; //Inicializar con valor del indice 0


            foreach (int numero1 in numeros)
            {
               if(numero1 < minimo)
               {
                  minimo = numero1; //Actualizar el valor minimo
               }
            }

            Console.WriteLine("El numero mas pequeño en la lista es > " + minimo);


            //Valores por interaciones
            //1 Numero valdria 24  minimo 24    Comparamos minimo = 24
            //2 Numero = 10 minimo 10   Comparamos minimo = 10
            //3 Numero = 8  minimo 8    Comparamos minimo =  8
            //4 Numero = 35 minimo 8    Comparamos minimo =  8
            //5 Numero = 14 minimo 8    Comparamos minimo =  8
            //6 Numero = 7 minimo 8     Comparamos minimo =  7

                
            Console.ReadKey();
            
        }
    }
}
