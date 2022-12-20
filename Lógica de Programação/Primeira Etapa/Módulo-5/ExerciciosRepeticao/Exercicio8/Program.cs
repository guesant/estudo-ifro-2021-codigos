using System;

namespace Exercicio8
{
  class Program
  {
    static void Main(string[] args)
    {
      double nota1, nota2, media;
      string continuar = "sim";

      do
      {
        Console.WriteLine("Nota 1:");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nota 2:");
        nota2 = Convert.ToDouble(Console.ReadLine());

        media = (nota1 + nota2) / (double)2;

        if (media >= 0 && media < 5)
        {
          Console.WriteLine("Reprovado");
        }
        else if (media >= 5 && media < 7)
        {
          Console.WriteLine("Exame");
        }
        else if (media >= 7 && media <= 10)
        {
          Console.WriteLine("Aprovado!");
        }

        Console.WriteLine("Deseja repetir? (sim/nao):");
        continuar = Console.ReadLine();
      } while (continuar != "nao");

      Console.ReadKey();
    }
  }
}
