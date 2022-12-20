using System;

namespace Cap5_Exercicio7
{
  class Program
  {
    static void Main(string[] args)
    {
      // declaração das variáveis
      double mediana;
      int soma = 0, contagem = 0, qntElementos, inicio, fim;

      Console.WriteLine("Número inicial:");
      inicio = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Número final:");
      fim = Convert.ToInt32(Console.ReadLine());

      // mediana = (inicio + fim) / 2

      qntElementos = fim - inicio + 1; // quantidade de elementos contidos no conjunto [inicio, fim]

      for (int i = inicio; i <= fim; i++)
      {
        // 0 [1] 2 - um elemento
        if (qntElementos % 2 == 1)
        {
          if (i == inicio + ((qntElementos - 1) / 2))
          {
            soma += i;
            contagem++;
          }
        }
        // 0 [1 2] 3 - dois elementos
        else
        {
          if (i == inicio + (qntElementos / 2) ||
              i == inicio + (qntElementos / 2) - 1)
          {
            soma += i;
            contagem++;
          }
        }
      }

      mediana = soma / (double)contagem;

      Console.WriteLine("A mediana da sequência [{0}, {1}] é {2:N2}", inicio, fim, mediana);
      Console.ReadKey();
    }
  }
}
