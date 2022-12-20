using System;

namespace Instrucoes_De_Repeticao
{
  class Program
  {
    static void Main(string[] args)
    {
      int soma = 0;
      string res;

      // while(soma <= 10) {
      //     Console.WriteLine("Deseja comprar um ingresso");
      //     res = Console.ReadLine();

      //     if(res == "sim") {
      //         soma++;
      //     }

      //     Console.WriteLine($"até agora vendemos: {soma} ingressos\n");
      // }


      do
      {
        Console.WriteLine("Deseja comprar um ingresso");
        res = Console.ReadLine();

        if (res == "sim")
        {
          soma++;
        }

        Console.WriteLine($"até agora vendemos: {soma} ingressos\n");
      } while (soma < 10);


      Console.WriteLine("Fim do programa ingressos");
      Console.ReadKey();
    }
  }
}
