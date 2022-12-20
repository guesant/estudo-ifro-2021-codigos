using System;

namespace Cap5_Exercicio4
{
  class Program
  {
    static void Main(string[] args)
    {
      // declaração das variáveis
      int inicio, fim;
      int positivos = 0, pares = 0, impares = 0, divisivel3e7 = 0;
      int somPositivos = 0, somPares = 0, somImpares = 0, somDivisivel3e7 = 0;
      double medPositivos, medPares, medImpares, medDivisivel3e7 = 0;

      Console.WriteLine("Começa em:");
      inicio = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Termina em:");
      fim = Convert.ToInt32(Console.ReadLine());

      // processamento
      for (int i = inicio; i <= fim; i++)
      {
        // positivos
        if (i > 0)
        {
          positivos++;
          somPositivos += i;
        }

        // pares
        if (i % 2 == 0)
        {
          pares++;
          somPares += i;
        }
        // ímpares
        else
        {
          impares++;
          somImpares += i;

          // ímpares divisíveis por 3 e 7
          if (i % 3 == 0 && i % 7 == 0)
          {
            divisivel3e7++;
            somDivisivel3e7 += i;
          }
        }
      }

      // processamento
      medPositivos = somPositivos / (double)positivos;
      medPares = somPares / (double)pares;
      medImpares = somImpares / (double)impares;
      medDivisivel3e7 = somDivisivel3e7 / (double)divisivel3e7;

      // saída
      Console.WriteLine("-----------------------------------------------------------");
      Console.WriteLine("*                Pares: | quantidade: {0} | média: {1}", pares, medPares);
      Console.WriteLine("-----------------------------------------------------------");
      Console.WriteLine("*              Ímpares: | quantidade: {0} | média: {1}", impares, medImpares);
      Console.WriteLine("-----------------------------------------------------------");
      Console.WriteLine("*            Positivos: | quantidade: {0} | média: {1}", positivos, medPositivos);
      Console.WriteLine("-----------------------------------------------------------");
      Console.WriteLine("* Divisíveis por 3 e 7: | quantidade: {0} | média: {1}", divisivel3e7, medDivisivel3e7);
      Console.WriteLine("-----------------------------------------------------------");


      Console.ReadKey();
    }
  }
}
