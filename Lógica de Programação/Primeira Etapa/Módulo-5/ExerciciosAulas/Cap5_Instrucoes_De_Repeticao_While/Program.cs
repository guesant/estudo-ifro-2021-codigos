using System;

namespace Instrucoes_De_Repeticao
{
  class Program
  {
    static void Main(string[] args)
    {
      int soma = 0;
      int valorDigitado;
      while (soma <= 1000)
      {
        Console.WriteLine("Digite um número para somar");
        valorDigitado = Convert.ToInt32(Console.ReadLine());
        soma += valorDigitado;

        Console.WriteLine($"A soma até agora é: {soma}\n");
      }
      Console.WriteLine("Fim do programa soma");


      Console.ReadKey();
    }
  }
}
