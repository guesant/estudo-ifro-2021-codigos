using System;

namespace Cap5_Exercicio8
{
  class Program
  {
    static void Main(string[] args)
    {
      // declaração das variáveis
      int num1, num2, soma;
      string continuar = null;

      do
      {
        // entrada de dados
        Console.WriteLine("Digite o primeiro número:");
        num1 = Convert.ToInt32(Console.ReadLine());

        // entrada de dados
        Console.WriteLine("Digite o segundo número:");
        num2 = Convert.ToInt32(Console.ReadLine());

        // processamento
        soma = num1 + num2;

        // saida
        Console.WriteLine("{0} + {1} = {2}", num1, num2, soma);

        // entrada de dados
        Console.WriteLine("Deseja continuar? (sim/nao):");
        continuar = Console.ReadLine();
      } while (continuar != "nao");

      Console.ReadKey();
    }
  }
}
