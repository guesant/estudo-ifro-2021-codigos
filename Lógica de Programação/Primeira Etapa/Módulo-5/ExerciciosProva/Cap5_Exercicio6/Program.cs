using System;

namespace Cap5_Exercicio6
{
  class Program
  {
    static void Main(string[] args)
    {
      // declaração das variáveis
      int digitado;
      double resultado;

      do
      {
        // entrada de dados
        Console.WriteLine("Digite um número (digite 1 para sair):");
        digitado = Convert.ToInt32(Console.ReadLine());

        // processamento
        if (digitado != 1)
        {
          if (digitado % 2 == 0)
          {
            resultado = digitado / (double)2;
          }
          else
          {
            resultado = digitado * 3 + 1;
          }

          // saída
          Console.WriteLine("Resultado: " + resultado);
        }
      } while (digitado != 1);

      Console.ReadKey();
    }
  }
}
