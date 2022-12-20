using System;

namespace Cap56_Exercicio5
{
  class Program
  {
    static void Main(string[] args)
    {
      uint contagem;
      int digitado, soma = 0;
      double media;

      Console.WriteLine("Deseja inserir quantos números?");
      contagem = Convert.ToUInt32(Console.ReadLine());

      for (int i = 0; i < contagem; i++)
      {
        Console.WriteLine("Digite o {0}º número:", i + 1);
        digitado = Convert.ToInt32(Console.ReadLine());
        soma += digitado;
      }

      // média = (a+b+...)/contagem
      media = soma / (double)contagem;
      Console.WriteLine("A média dos {0} números inserídos é {1:N2}", contagem, media);
      Console.ReadKey();
    }
  }
}
