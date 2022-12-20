using System;

namespace Cap4_Exercicio6
{
  class Program
  {
    static void Main(string[] args)
    {
      // declaração das variáveis
      int digitado;
      string continuar = "sim";

      do
      {
        // entrada de dados
        Console.WriteLine("Digite um número a ser analisado:");
        digitado = Convert.ToInt32(Console.ReadLine());

        // processamento        
        if (digitado % 2 == 0)
        {
          // saída
          Console.WriteLine("O número {0} é par", digitado);
        }
        else
        {
          // saída
          Console.WriteLine("O número {0} é ímpar", digitado);
        }

        // entrada de dados
        Console.WriteLine("Continuar? (sim/nao):");
        continuar = Console.ReadLine();
      } while (continuar != "nao");

      Console.ReadKey();
    }
  }
}
