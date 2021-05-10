using System;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o ano do seu nascimento?");
            int anoNasc = int.Parse(Console.ReadLine());

            int anoAtual = DateTime.Now.Year;

            int idade = anoAtual - anoNasc;

            if (idade >= 16)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você já poderá votar este ano!!");
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você ainda nao podera votar este ano!");
            }
        }
    }
}
