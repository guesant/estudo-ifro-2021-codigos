using System;

namespace Cap4_Exercicio2
{
  class Program
  {
    static void Main(string[] args)
    {
      double media;
      int num1, num2, num3, soma = 0;

      Console.WriteLine("Digite o 1º valor:");
      num1 = Convert.ToInt32(Console.ReadKey());

      Console.WriteLine("Digite o 2º valor:");
      num2 = Convert.ToInt32(Console.ReadKey());

      Console.WriteLine("Digite o 3º valor:");
      num3 = Convert.ToInt32(Console.ReadKey());

      soma = num1 + num2 + num3;
      media = soma / (double)3;

      Console.WriteLine("A média dos três valores digitados é {0}", media);
      Console.ReadKey();
    }
  }
}
