using System;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual combustivel você deseja abastecer?(A-álcool; G-gasolina");
            string tipo = Console.ReadLine().ToLower();
            Console.WriteLine("Quanto vc deseja abastecer em litros ?");
            double litros = double.Parse(Console.ReadLine());

            double alcool = 4.90;
            double gasolina = 5.30;

           switch (tipo)
           {
               case "a":
                    if (litros <= 20)
                    {
                        double litroA = (alcool*litros);
                        double valor = litroA*0.97;
                        Console.WriteLine("O valor com desconsto ficou de " + valor + "reais");
                    }else{
                        double litroA = (alcool*litros);
                        double valor = litroA*0.95;
                        Console.WriteLine("O valor com desconsto ficou de " + valor + "reais");
                    }
                   break;
                case "g":
                        if (litros > 20)
                        {
                            double litroG = (gasolina*litros);
                            double valorG = litroG*0.96;
                            Console.WriteLine("O valor com desconsto ficou de " + valorG + "reais");
                        }else{
                            double litroG = (gasolina*litros);
                            double valorG = litroG*0.94;
                            Console.WriteLine("O valor com desconsto ficou de " + valorG + "reais");
                        }
                    break;
               default:
                   break;
           }
           
            
        }
    }
}
