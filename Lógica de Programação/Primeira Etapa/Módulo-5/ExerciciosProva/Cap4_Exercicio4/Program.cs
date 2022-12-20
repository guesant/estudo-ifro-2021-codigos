using System;

namespace Cap4_Exercicio4
{
  class Program
  {
    static void Main(string[] args)
    {
      // declaração das variáveis
      string nome, continuar;
      double salarioAtual, salarioReajustado, aumento;

      do
      {
        // entrada de dados
        Console.WriteLine("Digite o nome do funcionário:");
        nome = Console.ReadLine();
        // entrada de dados
        Console.WriteLine("Digite o salário atual do funcionário:");
        salarioAtual = Convert.ToDouble(Console.ReadLine());

        // processamento
        aumento = salarioAtual * 0.0875;
        salarioReajustado = salarioAtual + aumento;

        // saída
        Console.WriteLine("O funcionário {0} possui, atualmente, um salário de {1:C2}.", nome, salarioAtual);
        Console.WriteLine("Após o reajuste de 8,75% passará a ter um salário de {0:C2}.", salarioReajustado);

        // entrada de dados
        Console.WriteLine("Deseja continuar? (sim/nao):");
        continuar = Console.ReadLine();
      } while (continuar != "nao");

      Console.ReadKey();
    }
  }
}
