﻿using System;

namespace exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        { 

            int[] numeros = null;
            numeros = new int[15];

            for (var i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}° numero:");
                numeros[i] = int.Parse(Console.ReadLine());

                
            }

            Console.WriteLine("");

            for (var i = (numeros.Length - 1); i >= 0; i--)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{numeros[i]}");
            }

            // double [] inverso = new double[numeros.Length];
            // int i2 = 0;
            // for (var i = numeros.Length; i > 0; i--)
            // {
            //     inverso[i2] = numeros[i - 1];
            //     i2 ++;
            // }
            // Console.WriteLine("");
            // foreach(var item in inverso){
            //     Console.ForegroundColor = ConsoleColor.Blue;
            //     Console.WriteLine(item);
            // }
        }
    }
}
