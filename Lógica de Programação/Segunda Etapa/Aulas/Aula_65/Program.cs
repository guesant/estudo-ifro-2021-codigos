using System;

namespace Aula_65
{
    class Program
    {
        static void Main(string[] args)
        {
            // array de três produtos
            String[] nomeProduto = new string[3];
            
            for(int i = 0; i < nomeProduto.Length; i++)
            {
                Console.WriteLine($"Digite o nome do {i+1} produto: ");
                nomeProduto[i] = Console.ReadLine();
            }

            for(int i = 0; i < nomeProduto.Length; i++)
            {
                Console.WriteLine($"Produto {i+1}: {nomeProduto[i]}.");
            }

            Console.ReadKey();
        }
    }
}
