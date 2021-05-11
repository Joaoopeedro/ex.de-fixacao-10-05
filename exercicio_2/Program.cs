using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {


            double alcool = 4.90;
            double gasolina = 5.30;
            bool consicao = false;
            int litros;
            
            do
            {
                Console.WriteLine("Qual combustivel você deseja abastecer?(A-álcool; G-gasolina");
                string tipo = Console.ReadLine().ToLower();
                switch (tipo)
                {
                    case "a":
                        Console.WriteLine("Quanto vc deseja abastecer em litros ?");
                        litros = int.Parse(Console.ReadLine());
                        if (litros <= 20)
                        {
                            double litroA = (alcool * litros);
                            double valor = litroA * 0.97;
                            Console.WriteLine("O valor com desconsto ficou de " + valor.ToString("N2") + "reais");
                        }
                        else
                        {
                            double litroA = (alcool * litros);
                            double valor = litroA * 0.95;
                            Console.WriteLine("O valor com desconsto ficou de " + valor.ToString("N2") + "reais");
                        }
                        consicao = true;
                        break;
                    case "g":
                        Console.WriteLine("Quanto vc deseja abastecer em litros ?");
                        litros = int.Parse(Console.ReadLine());
                        if (litros > 20)
                        {
                            double litroG = (gasolina * litros);
                            double valorG = litroG * 0.96;
                            Console.WriteLine("O valor com desconsto ficou de " + valorG.ToString("N2") + "reais");
                        }
                        else
                        {
                            double litroG = (gasolina * litros);
                            double valorG = litroG * 0.94;
                            Console.WriteLine("O valor com desconsto ficou de " + valorG.ToString("N2") + "reais");
                        }
                        consicao = true;
                        break;
                    default:
                        Console.WriteLine("Opção invalida , digite uma opção valida!");
                        break;
                }
            } while (consicao == false);




        }
    }
}
