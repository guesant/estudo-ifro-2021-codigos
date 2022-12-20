using System;

namespace Exercicio6
{
  class Program
  {
    static void Main(string[] args)
    {
      int soma = 0, digitado;

      do
      {
        Console.WriteLine("Digite um número inteiro (digite 0 para sair):");
        digitado = Convert.ToInt32(Console.ReadLine());

        if (digitado < 0)
        {
          soma += digitado;
        }
      } while (digitado != 0);

      Console.WriteLine("Somatório dos números negativos: {0}", soma);
      Console.ReadKey();
    }
  }
}
