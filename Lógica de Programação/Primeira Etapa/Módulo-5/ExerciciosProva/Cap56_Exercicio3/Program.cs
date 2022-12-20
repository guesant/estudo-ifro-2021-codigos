using System;

namespace Cap56_Exercicio3
{
  class Program
  {
    static void Main(string[] args)
    {
      int numero, fatorial = 1;

      Console.WriteLine("Digite um número inteiro e positivo:");
      numero = Convert.ToInt32(Console.ReadLine());

      for (int i = 2; i <= numero; i++)
      {
        fatorial *= i;
      }

      Console.WriteLine("{0}! = {1}", numero, fatorial);
      Console.ReadKey();
    }
  }
}
