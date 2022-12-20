using System;

namespace Aula_63
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] quantArray = new int[5];
            double[] preco = new double[100];
            String[] nomeProduto = new String[100];

            // inserindo diretamente
            // o primeiro item da array começa do índice 0
            quantArray[0] = 0;
            quantArray[1] = 10;
            quantArray[2] = 20;
            quantArray[3] = 30;
            quantArray[4] = 40;
            
            // entrada de dados
            Console.WriteLine("Digite o preço do 1º produto");
            preco[0] = Convert.ToDouble(Console.ReadLine());
            
            // entrada de dados
            Console.WriteLine("Digite o nome do 1º produto");
            nomeProduto[0] = Console.ReadLine();
            
            Console.ReadKey();
        }
    }
}
