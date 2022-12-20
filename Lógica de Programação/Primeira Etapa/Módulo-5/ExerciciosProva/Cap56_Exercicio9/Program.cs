using System;

namespace Cap56_Exercicio9
{
  class Program
  {
    static void Main(string[] args)
    {
      uint distancia;
      double horaEncontro, minutoEncontro, percorridoM, percorridoN;

      // M: 80 km/h (A->B)
      // N: 100 km/h (A<-B)

      // entrada de dados
      Console.WriteLine("Distância entre as cidades (em quilômetros):");
      distancia = Convert.ToUInt32(Console.ReadLine());

      // achar a hora e o minuto de encontro
      horaEncontro = distancia / (double)180;
      minutoEncontro = horaEncontro * 60;

      // achar a distância percorrida por ambos na hora do encontro
      percorridoM = horaEncontro * 80;
      percorridoN = horaEncontro * 100;

      // saída
      Console.WriteLine("Se encontrarão em {0:N0} minutos", minutoEncontro);
      Console.WriteLine("No minuto do encontro, M terá percorrido {0:N0} km e N {1:N0} km", percorridoM, percorridoN);
      Console.ReadKey();
    }
  }
}
