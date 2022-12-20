using System;

namespace Cap56_Exercicio7
{
  class Program
  {
    static void Main(string[] args)
    {
      int a, b, mdc = 1;

      // entrada de dados
      Console.WriteLine("Número A:");
      a = Convert.ToInt32(Console.ReadLine());

      // entrada de dados
      Console.WriteLine("Número B:");
      b = Convert.ToInt32(Console.ReadLine());

      // devemos listar os divisores de ambos os números e pegar o maior em comum.
      for (int i = Math.Min(a, b); i >= 1; i--)
      {
        bool divideA = a % i == 0;
        bool divideB = b % i == 0;
        bool maiorQueOAnterior = i > mdc;

        if (divideA && divideB && maiorQueOAnterior)
        {
          mdc = i;
        }
      }

      Console.WriteLine("mdc({0}, {1}) = {2}", a, b, mdc);
      Console.ReadKey();
    }
  }
}
