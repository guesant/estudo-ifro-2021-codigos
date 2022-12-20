using System;

namespace Cap3_Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Gabriel Rodrigues Antunes";
            int idade = 15;
            double peso = 58;
            
            Console.WriteLine("O {0} tem {1} anos e pesa {2:F2} kg", nome, idade, peso);
            Console.ReadKey();
        }
    }
}
