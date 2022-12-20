using System;

namespace Cap4_Exercicio9
{
  class Program
  {
    static void Main(string[] args)
    {
      // declaração das variáveis
      double media, final;
      uint prova1, prova2, prova3, exame;

      // entrada de dados
      Console.WriteLine("Nota da primeira prova:");
      prova1 = Convert.ToUInt16(Console.ReadLine());

      // entrada de dados
      Console.WriteLine("Nota da segunda prova:");
      prova2 = Convert.ToUInt16(Console.ReadLine());

      // entrada de dados
      Console.WriteLine("Nota da terceira prova:");
      prova3 = Convert.ToUInt16(Console.ReadLine());

      // processamento
      media = (prova1 + prova2 + prova3) / (double)3;

      // saída
      Console.WriteLine("- Média do aluno: {0:N2}", media);

      // processamento
      if (media >= 7)
      {
        // saída
        Console.WriteLine("Aprovado! Parabéns.");
      }
      else
      {
        // saída
        Console.WriteLine("Entrou em recuperação.");

        // entrada de dados
        Console.WriteLine("Nota do exame:");
        exame = Convert.ToUInt16(Console.ReadLine());

        // processamento
        final = (media + exame) / (double)2;

        // saída
        Console.WriteLine("- Média final: {0:N2}", final);

        // processamento
        if (final >= 5)
        {
          // saída
          Console.WriteLine("Aprovado!");
        }
        else
        {
          // saída
          Console.WriteLine("Reprovado.");
        }
      }

      Console.ReadKey();
    }
  }
}
