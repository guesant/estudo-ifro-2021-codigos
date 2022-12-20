using System;

namespace Cap5_Exercicio10
{
  class Program
  {
    static void Main(string[] args)
    {
      string continuar;
      double salarioBruto, salarioLiquido, impostoRecolher, inssRecolher;
      double mensalAliquota = 0, mensalParcela = 0, inssAliquota = 0;

      do
      {
        // entrada de dados
        Console.WriteLine("Digite o salário do funcionário:");
        salarioBruto = Convert.ToDouble(Console.ReadLine());

        // incidência mensal IRPF
        if (salarioBruto <= 1909.98)
        {
          mensalParcela = 0;
          mensalAliquota = 0;
        }
        else if (salarioBruto <= 2826.65)
        {
          mensalParcela = 142.8;
          mensalAliquota = 0.075;
        }
        else if (salarioBruto <= 3751.05)
        {
          mensalParcela = 142.8;
          mensalAliquota = 0.15;
        }
        else if (salarioBruto <= 4664.68)
        {
          mensalParcela = 636.13;
          mensalAliquota = 0.225;
        }
        else
        {
          mensalParcela = 869.36;
          mensalAliquota = 0.275;
        }

        // contribuição INSS
        if (salarioBruto <= 1556.94)
        {
          inssAliquota = 0.08;
        }
        else if (salarioBruto <= 2594.92)
        {
          inssAliquota = 0.09;
        }
        else if (salarioBruto <= 5189.92)
        {
          inssAliquota = 0.11;
        }

        // calculos dos descontos
        inssRecolher = salarioBruto * inssAliquota;
        impostoRecolher = (salarioBruto * mensalAliquota) + mensalParcela;

        // calculo do salário líquido
        salarioLiquido = salarioBruto - inssRecolher - impostoRecolher;

        // saída
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Folha de Pagamento");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Salário Bruto: {0:C2}", salarioBruto);
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("- INSS: {0:C2}", inssRecolher);
        Console.WriteLine("- Imposto de Renda: {0:C2}", impostoRecolher);
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Desconto Total: {0:C2}", inssRecolher + impostoRecolher);
        Console.WriteLine("Salário Líquido: {0:C2}", salarioLiquido);
        Console.WriteLine("--------------------------------------------");

        // entrada de dados
        Console.WriteLine("Deseja continuar? (S/n):");
        continuar = Console.ReadLine();
      } while (continuar != "n");
    }
  }
}
