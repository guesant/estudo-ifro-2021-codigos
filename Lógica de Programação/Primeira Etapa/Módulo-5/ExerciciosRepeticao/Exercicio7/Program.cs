using System;

namespace Exercicio7
{
  class Program
  {
    static void Main(string[] args)
    {
      double salario;
      string continuar = "sim", nome;

      do
      {
        Console.WriteLine("Digite o nome do funcionário:");
        nome = Console.ReadLine();

        Console.WriteLine("Digite o salário do funcionário:");
        salario = Convert.ToDouble(Console.ReadLine());

        if (salario >= 1000)
        {
          Console.WriteLine("O funcionário {0} possui um salário maior ou igual a R$ 1000,00", nome);
        }

        Console.WriteLine("Deseja cadastrar um novo funcionário? (sim/nao):");
        continuar = Console.ReadLine();
      } while (continuar != "nao");

      Console.ReadKey();
    }
  }
}
