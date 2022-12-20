using System;

namespace Cap4_Exercicio3
{
  class Program
  {
    static void Main(string[] args)
    {
      // declaração das variáveis
      string codigo, nome, continuar = "sim";
      double valorUnitario, quantidadeComprada, valorVenda;

      do
      {
        // entrada de dados
        Console.WriteLine("Código do produto:");
        codigo = Console.ReadLine();

        // entrada de dados
        Console.WriteLine("Nome do produto:");
        nome = Console.ReadLine();

        // entrada de dados
        Console.WriteLine("Valor unitário:");
        valorUnitario = Convert.ToDouble(Console.ReadLine());

        // entrada de dados
        Console.WriteLine("Quantidade comprada:");
        quantidadeComprada = Convert.ToDouble(Console.ReadLine());

        // processamento
        valorVenda = valorUnitario * quantidadeComprada;

        // saída
        Console.WriteLine("---------------------------");
        Console.WriteLine("CÓD: {0} - {1}", codigo, nome);
        Console.WriteLine("---------------------------");
        Console.WriteLine("Valor unitário: {0:C2}", valorUnitario);
        Console.WriteLine("---------------------------");
        Console.WriteLine("Quantidade comprada: {0:N2}", quantidadeComprada);
        Console.WriteLine("Valor de venda: {0:C2}", valorVenda);
        Console.WriteLine("---------------------------");

        // entrada de dados
        Console.WriteLine("Deseja continuar? (sim/nao):");
        continuar = Console.ReadLine();
      } while (continuar != "nao");

      Console.ReadKey();
    }
  }
}
