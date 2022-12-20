using System;

namespace Cap5_Exercicio5
{
  class Program
  {
    static void Main(string[] args)
    {
      // declaração das varíaveis
      int anterior = 0, atual = 1, proximo, n;

      // entrada de dados
      Console.WriteLine("Quantos números da sequencia de Fibonnaci deseja gerar?");
      n = Convert.ToInt32(Console.ReadLine());

      for (int i = 1; i <= n; i++)
      {
        // saída
        Console.WriteLine("Elemento {0}: {1}", i, atual);

        // processamento
        proximo = atual + anterior;
        anterior = atual;
        atual = proximo;
      }

      Console.ReadKey();
    }
  }
}
