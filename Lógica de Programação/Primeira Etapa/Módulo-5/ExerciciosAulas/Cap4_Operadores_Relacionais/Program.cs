using System;

namespace Operadores_Relacionais
{
  class Program
  {
    static void Main(string[] args)
    {
      int valor = 2;

      bool t = false;
      Console.WriteLine("Começou com: " + t);

      t = (valor == 2); // true
      Console.WriteLine("valor == 2: " + t);
      t = (valor != 2); // false
      Console.WriteLine("valor != 2: " + t);

      t = (valor < 2); // false
      Console.WriteLine("valor < 2: " + t);
      t = (valor <= 2); // true
      Console.WriteLine("valor <= 2: " + t);
      t = (valor > 1); // true
      Console.WriteLine("valor > 1: " + t);
      t = (valor >= 1); // true
      Console.WriteLine("valor >= 1: " + t);

      Console.ReadKey();
    }
  }
}
