using System;

namespace Cap56_Exercicio6
{
  class Program
  {
    static void Main(string[] args)
    {
      int numero, quantasVezesDividiu = 0;

      // entrada de dados
      Console.WriteLine("Digite um número (exceto 0 e 1):");
      numero = Convert.ToInt32(Console.ReadLine());

      // para cada numero entre 1 à N
      // calculamos a quantidade de divisões realizadas
      for (int i = 1; i <= numero; i++)
      {
        if (numero % i == 0)
        {
          quantasVezesDividiu++;
        }
      }

      if (quantasVezesDividiu == 2)
      {
        Console.WriteLine("{0} é um número primo!", numero);
      }
      else
      {
        Console.WriteLine("{0} não é um número primo.", numero);
      }

      Console.ReadKey();
    }
  }
}
