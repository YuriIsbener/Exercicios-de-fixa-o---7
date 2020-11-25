using System;

namespace Exercicios_de_fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[15];
            for (var i = 0; i < 15; i++)
            {
                Console.Write("Insira um valor: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(numeros);
            foreach (int item in numeros)
            {
            Console.WriteLine(item);
            }
        }
    }
}
