using System;

namespace Instrucao_IF_Else_MaiorIdade
{
  class Program
  {
    static void Main(string[] args)
    {
      int idade = 0, maiorIdade = 18;

      Console.WriteLine("Digite a sua idade");
      idade = Convert.ToInt16(Console.ReadLine());

      if (idade >= maiorIdade)
      {
        Console.WriteLine("Acesso liberado");
      }
      else
      {
        Console.WriteLine("Acesso negado!");
      }
      Console.ReadKey();
    }
  }
}
