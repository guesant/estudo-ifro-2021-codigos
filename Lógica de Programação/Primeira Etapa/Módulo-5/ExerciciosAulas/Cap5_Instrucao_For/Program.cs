using System;

namespace Cap5_Instrucao_For
{
  class Program
  {
    static void Main(string[] args)
    {
      int quantidade = 0, ingressos = 0;
      string res;

      Console.WriteLine("Quantos ingressos quer vender");
      quantidade = Convert.ToInt32(Console.ReadLine());

      for (int i = 0; i < quantidade; i++)
      {
        Console.WriteLine("Deseja comprar um ingresso");
        res = Console.ReadLine();
        if (res == "sim")
        {
          ingressos++;
        }

        Console.WriteLine("até agora vendemos: " + ingressos + " ingressos");
      }
    }
  }
}
