using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            int a = int.Parse(args[0]);
            
            int b = int.Parse(args[1]);
            
            Random rnd = new Random(b);
                for (int i = 0; i <a; i++) 
                {
                int valor = rnd.Next(1,7);
                soma += valor;
                }
                
            Console.WriteLine(soma);
        }
    }
}
