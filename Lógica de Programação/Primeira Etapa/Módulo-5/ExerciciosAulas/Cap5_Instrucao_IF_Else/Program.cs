using System;

namespace Instrucao_IF
{
  class Program
  {
    static void Main(string[] args)
    {
      double saldo;
      saldo = 340;

      Console.WriteLine("Digite o valor a ser sacado:");
      double saque = 0;
      saque = Convert.ToDouble(Console.ReadLine());

      // saltar o trecho do código,
      // caso não seja verdadeiro a condição.
      if (saldo >= saque)
      {
        saldo = saldo - saque;
        Console.WriteLine($"Após o saque de {saque}, seu saldo é:");
        Console.WriteLine(saldo);
      }
      else
      {
        Console.WriteLine("Saldo Insuficiente!!!");
        Console.WriteLine($"Seu saldo continua com: {saldo}");
      }

      Console.ReadKey();
    }
  }
}
