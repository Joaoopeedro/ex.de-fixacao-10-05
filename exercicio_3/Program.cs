using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o nome do seu produto?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a quantidade adquirida??");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o preço unitario??");
            double preco = double.Parse(Console.ReadLine());

            double total = quantidade * preco ;
            Console.WriteLine($"O valor total dos produtos é de R$ {(total).ToString("N2")}");

            if (quantidade <= 5)
            {
                double totalPagar = total * 0.98;
                Console.WriteLine("O valor a pagar é de R$ "+ totalPagar.ToString("F") );
            }
            else if (quantidade > 5 && quantidade<= 10)
            {
                double totalPagar = total * 0.97;
                Console.WriteLine("O valor a pagar é de R$ "+ totalPagar.ToString("F")  );
                
            }else{
                double totalPagar = total * 0.95;
                Console.WriteLine("O valor a pagar é de R$ "+ totalPagar.ToString("F")  );

            }

        }
    }
}
