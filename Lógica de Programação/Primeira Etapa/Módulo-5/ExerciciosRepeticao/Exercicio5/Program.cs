using System;

namespace Exercicio5
{
  class Program
  {
    static void Main(string[] args)
    {
      double media, digitado, soma = 0;
      int contagem = 0, positivos = 0, negativos = 0;

      do
      {
        Console.WriteLine("Digite um número (digite 0 para sair)");
        digitado = Convert.ToDouble(Console.ReadLine());

        if (digitado != 0)
        {
          soma += digitado;
          contagem++;

          if (digitado < 0)
          {
            negativos++;
          }
          else if (digitado > 0)
          {
            positivos++;
          }
        }

      } while (digitado != 0);

      media = soma / (double)contagem;

      Console.WriteLine("Foram digitados {0} números, dos quais: ", contagem);
      Console.WriteLine("{0} são positivos;", positivos);
      Console.WriteLine("{0} são negativos;", negativos);
      Console.WriteLine("A média dos números digitados é: {0}.", media);

      Console.ReadKey();
    }
  }
}
