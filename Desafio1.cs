using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre:");
            string Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese los ingresos de los últimos 3 meses:");

            double sumaIngresos = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Mes {i + 1}: Q");
                double ingresoMes = double.Parse(Console.ReadLine());
                sumaIngresos += ingresoMes;
            }
            double promedioIngresos = sumaIngresos / 3;

            Console.WriteLine($"Hola {Nombre}, en total ganaste Q{sumaIngresos} y promediaste Q{promedioIngresos.ToString("0.00")}.");
            Console.Read();
        }
    }
}
