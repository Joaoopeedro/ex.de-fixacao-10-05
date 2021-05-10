using System;

namespace exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] nome = null;
            nome = new  string[10];
            // string nomeCitado = "";


            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Escreava o {i + 1}° nome:");
                nome[i] = Console.ReadLine().ToLower();
                
            }

            Console.WriteLine("Digite o nome que vc deseja achar:");
            string nome2 = Console.ReadLine().ToLower();

            string chamado = "";
            for (var i = 0; i < 10; i++)
            {
                if (nome2 == nome[i])
                {
                    
                    chamado = "ACHEI" ;
                    break;
                }else{
                    
                    chamado = "NÂO ACHEI";
                    
                }
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($@"
            ===========
            |{chamado}|
            ===========");
        }
    }
}
