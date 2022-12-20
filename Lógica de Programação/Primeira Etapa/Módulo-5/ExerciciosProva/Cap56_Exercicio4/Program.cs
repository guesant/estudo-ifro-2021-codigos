using System;

namespace Cap56_Exercicio4
{
  class Program
  {
    static void Main(string[] args)
    {
      uint numbase, expoente;

      // entrada de dados
      Console.WriteLine("Base:");
      numbase = Convert.ToUInt32(Console.ReadLine());

      Console.WriteLine("Expoente:");
      expoente = Convert.ToUInt32(Console.ReadLine());

      // processamento
      // como nos está sendo pedido a múltiplicação sucessiva arbitrária,
      // definido pelo usuário, podemos fazer isso dentro de um loop.

      // Para isso, dividimos o processo em etapas.
      // Ex.: 2^4 = (2)*(2)*(2)*(2)
      // Fazemos um chunk de dois em dois em cada iteração do loop.

      uint atual = numbase;
      for (int i = 0; i < expoente; i++)
      {
        atual = atual * numbase;
        Console.WriteLine("{0}^{1} = {2}", numbase, i + 1, atual);
      }

      Console.ReadKey();
    }
  }
}
