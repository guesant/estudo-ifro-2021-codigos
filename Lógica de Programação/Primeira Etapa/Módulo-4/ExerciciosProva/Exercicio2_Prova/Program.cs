using System;

namespace Exercicio2_Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração das variáveis
            int NumA, NumB;
            
            // usuário digita o número A
            Console.WriteLine("Digite o primeiro número e depois pressione enter:");            
            NumA = Convert.ToInt32(Console.ReadLine());
            
            // usuário digita o número B
            Console.WriteLine("Digite o segundo número e depois pressione enter:");            
            NumB = Convert.ToInt32(Console.ReadLine());
            
            // mostrando os números ao usuário...
            Console.WriteLine();
            Console.WriteLine("Último número digitado: " + NumB);
            Console.WriteLine("Primeiro número digitado: " + NumA);
            Console.ReadKey();
        }
    }
}
