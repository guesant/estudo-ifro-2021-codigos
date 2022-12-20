using System;

namespace Cap56_Exercicio1
{
  class Program
  {
    static void Main(string[] args)
    {
      uint contagem_1_4 = 0, contagem_2_4 = 0, contagem_3_4 = 0, contagem_4_4 = 0;

      int digitado;

      do
      {
        Console.WriteLine("Digite um número de 0 a 100 (ou negativo para sair):");
        digitado = Convert.ToInt32(Console.ReadLine());

        if (digitado < 0)
        {
          break;
        }
        else if (digitado < 26)
        {
          contagem_1_4++;
        }
        else if (digitado < 51)
        {
          contagem_2_4++;
        }
        else if (digitado < 76)
        {
          contagem_3_4++;
        }
        else if (digitado <= 100)
        {
          contagem_4_4++;
        }



      } while (true);

      Console.WriteLine("Contagem dos números digitados:");
      Console.WriteLine("- Entre 0 e 25.9: {0}", contagem_1_4);
      Console.WriteLine("- Entre 26 e 50.9: {0}", contagem_2_4);
      Console.WriteLine("- Entre 51 e 75.9: {0}", contagem_3_4);
      Console.WriteLine("- Entre 76 e 100.0: {0}", contagem_4_4);

      Console.ReadKey();

    }
  }
}
