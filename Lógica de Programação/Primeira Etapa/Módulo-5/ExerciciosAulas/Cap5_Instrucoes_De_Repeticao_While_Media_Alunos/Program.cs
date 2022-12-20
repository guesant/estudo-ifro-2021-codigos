using System;

namespace Decisao_Encadeada
{
  class Program
  {
    static void Main(string[] args)
    {
      int media;
      int quantidade = 0;

      do
      {
        Console.WriteLine("Digite a média do aluno:");

        media = Convert.ToInt16(Console.ReadLine());
        quantidade++;

        if (media >= 60)
        {
          if (media > 90)
          {
            Console.WriteLine("Parabéns pelo seu notão!");
          }
          Console.WriteLine("Já passou!");
        }
        else
        {
          Console.WriteLine("Você ficou de recuperação.");
          Console.WriteLine("Digite a média da recuperação:");
          media = Convert.ToInt16(Console.ReadLine());

          if (media >= 60)
          {
            Console.WriteLine("Parabéns, você passou na recuperação!");
          }
          else
          {
            Console.WriteLine("Você ficou reprovado.");
          }
        }

        Console.WriteLine();
      } while (quantidade < 30);
      Console.ReadKey();
    }
  }
}
