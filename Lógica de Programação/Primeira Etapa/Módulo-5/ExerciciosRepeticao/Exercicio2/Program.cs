using System;

namespace Exercicio2
{
  class Program
  {
    static void Main(string[] args)
    {
      double digitado;

      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine("Digite um número a ser analizado:");
        digitado = Convert.ToDouble(Console.ReadLine());

        if (digitado % 3 == 0)
        {
          Console.WriteLine("{0} é um múltiplo de três.", digitado);
        }
        else
        {
          Console.WriteLine("{0} não é um múltiplo de três.", digitado);
        }

        Console.WriteLine("--------------------------------");
      }

      Console.ReadKey();
    }
  }
}
