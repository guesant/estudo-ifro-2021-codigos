using System;

namespace Exercicio1
{
  class Program
  {
    static void Main(string[] args)
    {
      int contagem = 0;
      double digitado;

      for (int i = 0; i < 30; i++)
      {
        Console.WriteLine("Digite um número:");
        digitado = Convert.ToDouble(Console.ReadLine());

        if (digitado > 100)
        {
          contagem++;
        }
      }

      Console.WriteLine();
      Console.WriteLine("Quantidade de números digitados maiores do que 100: {0:D2}", contagem);
      Console.ReadKey();
    }
  }
}
