using System;

namespace Cap4_Exercicio6
{
  class Program
  {
    static void Main(string[] args)
    {
      int digitado;
      string continuar = "s";

      while (continuar != "n")
      {
        // entrada de dados
        Console.WriteLine("Digite um número a ser analisado:");
        digitado = Convert.ToInt32(Console.ReadLine());

        // processamento
        bool multiploDeTres = digitado % 3 == 0;
        bool multiploDeSete = digitado % 7 == 0;

        // saída
        Console.WriteLine("O número {0} é:", digitado);
        Console.WriteLine("- múltiplo de 3? " + (multiploDeTres ? "sim" : "nao"));
        Console.WriteLine("- múltiplo de 7? " + (multiploDeSete ? "sim" : "nao"));
        Console.WriteLine("--------------------");

        // entrada de dados
        Console.WriteLine("Continuar? (S/n):");
        continuar = Console.ReadLine();
      }

      Console.ReadKey();
    }
  }
}
