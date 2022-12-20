using System;

namespace Cap4_Exercicio1
{
  class Program
  {
    static void Main(string[] args)
    {
      int num1, num2, num3, num4, soma = 0;

      Console.WriteLine("Digite o 1º valor:");
      num1 = Convert.ToInt32(Console.ReadKey());

      Console.WriteLine("Digite o 2º valor:");
      num2 = Convert.ToInt32(Console.ReadKey());

      Console.WriteLine("Digite o 3º valor:");
      num3 = Convert.ToInt32(Console.ReadKey());

      Console.WriteLine("Digite o 4º valor:");
      num4 = Convert.ToInt32(Console.ReadKey());

      soma = num1 + num2 + num3 + num4;

      Console.WriteLine("A soma dos quatro valores digitados é {0}", soma);
      Console.ReadKey();
    }
  }
}
