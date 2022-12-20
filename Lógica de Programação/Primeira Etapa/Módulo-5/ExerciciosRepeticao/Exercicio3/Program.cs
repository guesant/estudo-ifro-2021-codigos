using System;

namespace Exercicio3
{
  class Program
  {
    static void Main(string[] args)
    {
      int contagem = 0;
      double media, digitado, soma = 0;

      do
      {
        Console.WriteLine("Digite um número (digite 0 para sair):");
        digitado = Convert.ToDouble(Console.ReadLine());

        if (digitado != 0)
        {
          soma += digitado;
          contagem++;
        }
      } while (digitado != 0);

      Console.WriteLine("--------------------------------");
      Console.WriteLine("Calculando a média dos números digitados...");
      Console.WriteLine("--------------------------------");

      // usamos o double para permitir resultados decimais, ex.: 11/2 = 5,5
      media = soma / (double)contagem;

      Console.WriteLine("Média dos números digitados: {0}.", media);
      Console.WriteLine("--------------------------------");

      Console.ReadKey();
    }
  }
}
