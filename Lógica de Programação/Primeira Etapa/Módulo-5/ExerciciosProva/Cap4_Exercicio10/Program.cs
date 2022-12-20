using System;

namespace Cap4_Exercicio10
{
  class Program
  {
    static void Main(string[] args)
    {
      // declaração das variáveis
      int parcelas;
      double compra, calculado = 0;

      // entrada de dados
      Console.WriteLine("Digite o valor total da compra:");
      compra = Convert.ToDouble(Console.ReadLine());

      // entrada de dados
      Console.WriteLine("-------------------");
      Console.WriteLine("Forma de pagamento:");
      Console.WriteLine("[1]: à vista (desconto de 5%)");
      Console.WriteLine("[3]: 3 parcelas");
      Console.WriteLine("[5]: 5 parcelas (acréscimo de 2%)");
      Console.WriteLine("[10]: 10 parcelas (acréscimo de 8%)");
      parcelas = Convert.ToInt16(Console.ReadLine());

      if (parcelas == 1)
      {
        calculado = compra * 0.95; // -5%
      }
      else if (parcelas == 3)
      {
        calculado = compra;
      }
      else if (parcelas == 5)
      {
        calculado = compra * 1.02; // +2%
      }
      else if (parcelas == 10)
      {
        calculado = compra * 1.08; // +8%
      }

      // saída
      Console.WriteLine("Total: {0:C2}.", compra); // sem desconto ou acréscimo
      Console.WriteLine("--------------------");
      Console.WriteLine("Valor de cada parcela: " + calculado / parcelas);
      Console.WriteLine("Final: " + calculado);
      Console.WriteLine("--------------------");

      Console.ReadKey();
    }
  }
}
