using System;

namespace exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada do 1 ao 10");
           
            for (var i = 1; i <= 10 ; i++)
            {
                
                Console.WriteLine($"\nTabuada do {i}");

                for (var r = 1; r < 11; r++)
                {
                    Console.WriteLine($"{i} x {r} = {i*r}");
                }
            }
            
        }
    }
}
