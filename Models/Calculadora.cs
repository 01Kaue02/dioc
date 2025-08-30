using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dioc.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"O resultado da soma é: {x + y}");
        }
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"O resultado da soma é: {x - y}");
        }
        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"O resultado da soma é: {x * y}");

        } 
        public void Dividir(int a, int b)
{
    if (b != 0)
        Console.WriteLine($"Divisão: {(double)a / b}");
    else
        Console.WriteLine("Não é possível dividir por zero.");
}
    }
}