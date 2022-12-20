using System;

namespace Aula_64
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nomeProduto = new String[100];
            
            // entrada de dados
            Console.WriteLine("Digite o nome do 1º produto");
            nomeProduto[0] = Console.ReadLine();

            // saída de dados
            Console.WriteLine("O nome do 1º produto é " + nomeProduto[0]);

            Console.ReadKey();
        }
    }
}
