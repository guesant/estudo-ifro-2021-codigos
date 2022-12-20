using System;

namespace Operadores_Strings
{
  class Program
  {
    static void Main(string[] args)
    {
      string s = "  Gabriel Rodrigues Antunes   ";

      // tamanho
      int length = s.Length;
      Console.WriteLine($"Tamanho: {length}");

      // char c = s[3];
      // Console.WriteLine(c);

      // contém
      Console.WriteLine(s.Contains("antunes"));
      Console.WriteLine(s.Contains("Antunes"));

      // termina com
      Console.WriteLine(s.EndsWith("ant"));
      Console.WriteLine(s.EndsWith("unes"));

      // começa com            
      Console.WriteLine(s.StartsWith("Gabr"));


      string resultado4 = s.Substring(2, 9);
      Console.WriteLine(resultado4);

      string resultado5 = s.Replace("Gabriel", "Rafael Messias");
      Console.WriteLine(resultado5);


      string resultado6 = s.ToUpper();
      Console.WriteLine(resultado6);

      string resultado7 = s.ToLower();
      Console.WriteLine(resultado7);

      string resultado8 = s.Trim();
      Console.WriteLine(resultado8);

      Console.ReadKey();
    }
  }
}
