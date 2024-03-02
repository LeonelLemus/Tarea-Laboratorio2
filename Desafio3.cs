using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_3
{
    class Desafio3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce dos valores para sumar:");
            Console.Write("Valor 1: ");
            string input1 = Console.ReadLine();
            Console.Write("Valor 2: ");
            string input2 = Console.ReadLine();

            try
            {
                int resultado = SumarValores(input1, input2);
                Console.WriteLine("La suma es: " + resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Uno de los valores introducidos no es un número válido.");
            }
            Console.Read();
        }

        static int SumarValores(string input1, string input2)
        {
            int valor1 = int.Parse(input1);
            int valor2 = int.Parse(input2);
            return valor1 + valor2;
        }
    }
}