using System;

namespace Cap3_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            
            double numeroAleatorio = gerador.NextDouble() * 100;
            
            Console.WriteLine(numeroAleatorio);
            
            Console.ReadKey();
        }
    }
}
