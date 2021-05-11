using System;

namespace exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // int maior = 0, menor, i = 0, numero = 0, tl = 0;
            
            int[] numeros = null;
            numeros = new int [10];
            // float maior = 0;
            // float menor = 0;

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Infirme o {(i + 1)}° valor");
                numeros[i] = int.Parse(Console.ReadLine());

                
            }
            Array.Sort(numeros);
            // foreach (var i in numeros)
            // {
            //     Console.WriteLine(i);
            // }
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"O menor numero é: {numeros[0]}");
            Console.WriteLine($"O maior numero é: {numeros[(numeros.Length - 1)]}");

















        }
    }
}
