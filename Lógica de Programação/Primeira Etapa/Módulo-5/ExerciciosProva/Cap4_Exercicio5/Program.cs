using System;

namespace Cap4_Exercicio5
{
  class Program
  {
    static void Main(string[] args)
    {
      double precoAtual, comDesconto;
      string continuar = "sim";

      do
      {
        // entrada de dados
        Console.WriteLine("Digite o preço atual do produto:");
        precoAtual = Convert.ToDouble(Console.ReadLine());

        // processamento
        comDesconto = precoAtual * 0.9; // -10%

        // saída
        Console.WriteLine("Incrível promoção!!!");
        Console.WriteLine("De {0:C2} por apenas {1:C2}!!! Aproveite logo!", precoAtual, comDesconto);

        // entrada de dados
        Console.WriteLine("Deseja continuar? (sim/nao):");
        continuar = Console.ReadLine();
      } while (continuar != "nao");

      Console.ReadKey();
    }
  }
}
