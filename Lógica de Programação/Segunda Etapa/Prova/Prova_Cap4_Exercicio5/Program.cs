using System;

namespace Prova_Cap4_Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double precoAtual = perguntarPreco();
            mostrarDesconto(precoAtual);
            Console.ReadKey();
        }

        static double perguntarPreco() {
            double preco;
            Console.Write("Digite o preço atual: ");
            preco = Convert.ToDouble(Console.ReadLine());
            return preco;
        }
        
        static void mostrarDesconto(double precoAtual) {
            double precoComDesconto = calcularDesconto(precoAtual);
            Console.WriteLine("------------------------------");
            Console.WriteLine("- Preço atual: {0:C2}", precoAtual);
            Console.WriteLine("- Preço com desconto: {0:C2}", precoComDesconto);
        }

        static double calcularDesconto(double valor) 
        {
            return valor * 0.9;
        }
    }
}
