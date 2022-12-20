using System;

namespace Exercicio4
{
  class Program
  {
    static void Main(string[] args)
    {
      double media;
      int soma = 0, contagem = 0, digitado;

      do
      {
        Console.WriteLine("Digite um número inteiro (negativo para sair): ");
        digitado = Convert.ToInt32(Console.ReadLine());

        if (digitado > 0)
        {
          soma += digitado;
          contagem++;
        }
      } while (digitado > 0);

      Console.WriteLine("---------------------------------------");
      Console.WriteLine("Calculando a média dos números positivos digitados...");
      Console.WriteLine("---------------------------------------");

      media = soma / (double)contagem;

      Console.WriteLine("Média dos números positivos digitados: {0}.", media);
      Console.WriteLine("---------------------------------------");
      Console.ReadKey();
    }
  }
}
