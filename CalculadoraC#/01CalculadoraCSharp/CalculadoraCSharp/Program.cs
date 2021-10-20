using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroA, numeroB, resultado, operacion;

            Console.WriteLine("Bienvenido a mi calculadora");

            Console.WriteLine("Ingrese un numero");
            numeroA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero");
            numeroB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tipo de operacion\n1-Suma\n2-Resta\n3-Multiplicacion\n4-Division");
            operacion = Convert.ToInt32(Console.ReadLine());

            switch (operacion)
            {
                case 1:
                    resultado = numeroA + numeroB;
                    Console.WriteLine("El resultado de la Suma es");
                    Console.WriteLine(resultado);
                    break;

                case 2:
                    resultado = numeroA - numeroB;
                    Console.WriteLine("El resultado de la Resta es");
                    Console.WriteLine(resultado);
                    break;

                case 3:
                    resultado = numeroA * numeroB;
                    Console.WriteLine("El resultado de la Multiplicacion es");
                    Console.WriteLine(resultado);
                    break;

                case 4:
                    resultado = numeroA / numeroB;
                    Console.WriteLine("El resultado de la Division es");
                    Console.WriteLine(resultado);
                    break;


            }



            Console.ReadKey();
        }
    }
}
