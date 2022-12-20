using System;

namespace Cap5_Exercicio3
{
  class Program
  {
    static void Main(string[] args)
    {
      // declaração das variáveis
      int n;

      // entrada de dados
      Console.WriteLine("Digite o número da tabuada que desejas:");
      n = Convert.ToInt32(Console.ReadLine());

      // processamento
      for (int i = 1; i <= n; i++)
      {
        // saída
        Console.WriteLine("--------------");
        Console.WriteLine("Tabuada do " + i);
        Console.WriteLine("--------------");

        // processamento
        for (int j = 1; j <= 9; j++)
        {
          // processamento
          int resultadoMultiplicacao = i * j;

          // saída
          Console.WriteLine("{0} x {1} = {2}", i, j, resultadoMultiplicacao);
        }

        // saída
        Console.WriteLine("--------------");
        Console.WriteLine();
      }

      Console.ReadKey();
    }
  }
}
