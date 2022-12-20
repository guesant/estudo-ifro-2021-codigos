using System;

namespace Cap5_Exercicio2
{
  class Program
  {
    static void Main(string[] args)
    {
      // declaração das variáveis
      double inicialPedro = 1.50; // em metros
      double inicialLucas = 1.10; // em metros
      int pedroCrescimento = 2; // em centímetros
      int lucasCrescimento = 3; // em centímetros

      // declaração das variáveis
      int alturaFuturaPedro, alturaFuturaLucas; // altura de cada um em centímetros
      int iguaisDaquiQuantosAnos = 0, lucasMaiorDaquiQuantosAnos = 0;

      // PEDRO == LUCAS
      alturaFuturaPedro = Convert.ToInt32(inicialPedro * 100); // metro para centímetros
      alturaFuturaLucas = Convert.ToInt32(inicialLucas * 100); // metro para centímetros
      while (alturaFuturaPedro != alturaFuturaLucas)
      {
        alturaFuturaPedro += pedroCrescimento;
        alturaFuturaLucas += lucasCrescimento;
        iguaisDaquiQuantosAnos++;
      }
      // FIM PEDRO == LUCAS

      // LUCAS > PEDRO
      alturaFuturaPedro = Convert.ToInt32(inicialPedro * 100); // metro para centímetros
      alturaFuturaLucas = Convert.ToInt32(inicialLucas * 100); // metro para centímetros
      while (alturaFuturaLucas <= alturaFuturaPedro)
      {
        alturaFuturaPedro += pedroCrescimento;
        alturaFuturaLucas += lucasCrescimento;
        lucasMaiorDaquiQuantosAnos++;
      }
      // FIM LUCAS > PEDRO

      Console.WriteLine("Pedro == Lucas daqui a " + iguaisDaquiQuantosAnos + " anos.");
      Console.WriteLine("Lucas > Pedro daqui a " + lucasMaiorDaquiQuantosAnos + " anos.");
      Console.ReadKey();
    }
  }
}
