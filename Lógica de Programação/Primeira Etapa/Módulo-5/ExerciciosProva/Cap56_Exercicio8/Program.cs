using System;

namespace Cap56_Exercicio8
{
  class Program
  {
    static void Main(string[] args)
    {
      int inicio, fim, somaDivisores;

      // entrada de dados
      Console.WriteLine("Início:");
      inicio = Convert.ToInt32(Console.ReadLine());

      // entrada de dados
      Console.WriteLine("Fim:");
      fim = Convert.ToInt32(Console.ReadLine());

      for (int i = inicio; i <= fim; i++)
      {
        somaDivisores = 0;

        for (int j = 1; j < i; j++)
        {
          if (i % j == 0)
          {
            somaDivisores += j;
          }
        }

        if (somaDivisores == i)
        {
          Console.WriteLine("O número {0} é um número perfeito.", i);
        }
      }

      Console.WriteLine("pressione qualquer tecla para sair");
      Console.ReadKey();
    }
  }
}
