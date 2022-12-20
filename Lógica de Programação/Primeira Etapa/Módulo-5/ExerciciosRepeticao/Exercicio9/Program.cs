using System;

namespace Exercicio9
{
  class Program
  {
    static void Main(string[] args)
    {
      double preco, precoComAcrescimo;
      string continuar = "sim", nome;

      do
      {
        Console.WriteLine("Digite o nome do produto:");
        nome = Console.ReadLine();

        Console.WriteLine("Digite o preço de custo:");
        preco = Convert.ToDouble(Console.ReadLine());

        // precoComAcrescimo = preco + (preco * 0.15);
        precoComAcrescimo = preco * 1.15;

        Console.WriteLine("O produto {0} passará a custar {1:C2}.", nome, precoComAcrescimo);

        Console.WriteLine("Deseja continuar? (sim/nao):");
        continuar = Console.ReadLine();
      } while (continuar != "nao");

      Console.ReadKey();
    }
  }
}
