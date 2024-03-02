using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Desafio2
{
    public int Sumar(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Restar(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }

    public int Dividir(int num1, int num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
            return 0;
        }
        else
        {
            return num1 / num2;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Desafio2 miCalculadora = new Desafio2();

        Console.WriteLine("Ingrese el primer número:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Suma: {miCalculadora.Sumar(numero1, numero2)}");
        Console.WriteLine($"Resta: {miCalculadora.Restar(numero1, numero2)}");
        Console.WriteLine($"Multiplicación: {miCalculadora.Multiplicar(numero1, numero2)}");
        Console.WriteLine($"División: {miCalculadora.Dividir(numero1, numero2)}");
        Console.Read();
    }
}
