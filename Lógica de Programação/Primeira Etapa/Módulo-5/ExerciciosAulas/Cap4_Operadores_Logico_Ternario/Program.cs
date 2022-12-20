using System;

namespace Operadores_Logico_Ternario
{
  class Program
  {
    static void Main(string[] args)
    {
      // double nota = 0.4;

      Random gerador = new Random();
      double nota = gerador.NextDouble();

      Console.WriteLine(nota >= 0.6 ? "aprovado" : "reprovado");

      int i;

      i = 10;
      Console.WriteLine(i++);

      i = 10;
      Console.WriteLine(++i);

      i = 10;
      Console.WriteLine(i++ == 10);

      i = 10;
      Console.WriteLine(++i == 11);

      Console.ReadKey();
    }
  }
}
