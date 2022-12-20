using System;

namespace Cap56_Exercicio2
{
  class Program
  {
    static void Main(string[] args)
    {

      // dados que serão digitados em cada cíclo
      string sexo, continuar = "s";
      double peso;
      uint olhos, cabelo, idade, altura;

      // dados que serão apresentados ao usuário
      uint contagem = 0, contagemMasc = 0, contagemFem = 0, contagemVerdeLouro = 0;
      double mediaIdade, mediaPeso, mediaAltura, somaIdade = 0, somaPeso = 0, somaAltura = 0;
      double porcentagemFem, porcentagemMasc;

      do
      {
        // entrada de dados
        Console.WriteLine("Sexo (m/f):");
        sexo = Console.ReadLine();

        Console.WriteLine("Cor dos olhos (1=azul, 2=verde, 3=castanho):");
        olhos = Convert.ToUInt16(Console.ReadLine());

        Console.WriteLine("Cor dos cabelos (1=loiro, 2=castanho, 3=preto):");
        cabelo = Convert.ToUInt16(Console.ReadLine());

        Console.WriteLine("Idade:");
        idade = Convert.ToUInt16(Console.ReadLine());

        Console.WriteLine("Altura (em centímetros):");
        altura = Convert.ToUInt16(Console.ReadLine());

        Console.WriteLine("Peso:");
        peso = Convert.ToDouble(Console.ReadLine());
        // fim entrada de dados


        // processamento
        contagem++;
        if (sexo == "m")
        {
          contagemMasc++;
        }
        else if (sexo == "f")
        {
          contagemFem++;
        }

        somaPeso += peso;
        somaIdade += idade;
        somaAltura += altura;

        if (cabelo == 1 && olhos == 2)
        {
          contagemVerdeLouro++;
        }

        // entrada de dados
        Console.WriteLine("Deseja fornecer mais dados sobre os habitantes? (s/n):");
        continuar = Console.ReadLine();
      } while (continuar != "n");

      // média
      mediaPeso = somaPeso / (double)contagem;
      mediaIdade = somaIdade / (double)contagem;
      mediaAltura = somaAltura / (double)contagem;

      // porcentagem
      porcentagemFem = contagemFem / (double)contagem * 100;
      porcentagemMasc = contagemMasc / (double)contagem * 100;

      // saida
      Console.WriteLine("---------------------------------------------");
      Console.WriteLine("Média da idade dos participantes: {0:N2}", mediaIdade);
      Console.WriteLine("Média do peso dos participantes: {0:N2}", mediaPeso);
      Console.WriteLine("Média da altura dos participantes: {0:N2}", mediaAltura);
      Console.WriteLine("---------------------------------------------");
      Console.WriteLine("{0:N2}% (feminino) x {1:N2}% (masculino)", porcentagemFem, porcentagemMasc);
      Console.WriteLine("{0} pessoa(s) possuem os olhos verdes e cabelos louros", contagemVerdeLouro);
      Console.WriteLine("---------------------------------------------");

      Console.ReadKey();
    }
  }
}
