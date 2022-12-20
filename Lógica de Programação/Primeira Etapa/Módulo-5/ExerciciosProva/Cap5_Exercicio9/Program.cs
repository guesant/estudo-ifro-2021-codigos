using System;

namespace Cap5_Exercicio9
{
  class Program
  {
    static void Main(string[] args)
    {
      // declaração das variáveis
      string continuar = null;
      uint mascContagem = 0, mascExpContagem = 0, mascExpIdadeSoma = 0, mascContagem35_45 = 0;
      uint femContagem = 0, femExperienciaContagem = 0, femExperienciaIdadeSoma = 0;
      uint? femExperienciaIdadeMenor = null;

      double femExperienciaIdadeMedia, mascExpIdadeMedia, mascPorcentagem35_45;
      uint fundamental = 0, medio = 0, superior = 0, posgraduacao = 0;

      do
      {
        // entrada de dados
        Console.WriteLine("Idade do candidato:");
        uint idade = Convert.ToUInt32(Console.ReadLine());

        // entrada de dados
        Console.WriteLine("Sexo do candidato [m/f]:");
        string sexo = Console.ReadLine();

        // entrada de dados
        Console.WriteLine("Possúi experiência? [s/n]:");
        string experiencia = Console.ReadLine();

        // entrada de dados
        Console.WriteLine("Escolaridade? [fundamental/medio/superior/posgraduacao]:");
        string escolaridade = Console.ReadLine();

        // processamento
        if (sexo == "m")
        {
          mascContagem++;
          if (experiencia == "s")
          {
            mascExpContagem++;
            mascExpIdadeSoma += idade;
          }

          if (idade >= 35 && idade <= 45)
          {
            mascContagem35_45++;
          }
        }
        else if (sexo == "f")
        {
          femContagem++;
          if (experiencia == "s")
          {
            femExperienciaContagem++;
            femExperienciaIdadeSoma += idade;

            if (femExperienciaIdadeMenor == null || idade < femExperienciaIdadeMenor)
            {
              femExperienciaIdadeMenor = idade;
            }
          }
        }

        if (escolaridade == "fundamental")
        {
          fundamental++;
        }
        else if (escolaridade == "medio")
        {
          medio++;
        }
        else if (escolaridade == "superior")
        {
          superior++;
        }
        else if (escolaridade == "posgraduacao")
        {
          posgraduacao++;
        }

        // entrada de dados
        Console.WriteLine("Deseja cadastrar outro candidato? [s/n]:");
        continuar = Console.ReadLine();
      } while (continuar != "n");

      // processamento
      mascPorcentagem35_45 = mascContagem35_45 / (double)mascContagem * 100;
      mascExpIdadeMedia = mascExpIdadeSoma / (double)mascExpContagem;
      femExperienciaIdadeMedia = femExperienciaIdadeSoma / (double)femExperienciaContagem;

      Console.WriteLine("------------------------------");
      Console.WriteLine(" - Cand. Fem: " + femContagem);
      Console.WriteLine(" - Cand. Masc: " + mascContagem);
      Console.WriteLine("------------------------------");
      Console.WriteLine(" - Méd. Idad. Fem. Exp.: {0:N0}", femExperienciaIdadeMedia);
      Console.WriteLine(" - Méd. Idad. Masc. Exp.: {0:N0}", mascExpIdadeMedia);
      Console.WriteLine("------------------------------");
      Console.WriteLine(" - Masc. 35-45 anos: {0}% de {1}", mascPorcentagem35_45, mascContagem);
      Console.WriteLine("------------------------------");

      Console.WriteLine(" - A menor idade entre as mulherem com experiência: " + femExperienciaIdadeMenor);
      Console.WriteLine("------------------------------");

      Console.WriteLine("Escolaridade dos Candidatos:");
      Console.WriteLine(" - Ens. Fundamental: " + fundamental);
      Console.WriteLine(" - Ens. Médio: " + medio);
      Console.WriteLine(" - Ens. Superior: " + superior);
      Console.WriteLine(" - Pós Graduação: " + posgraduacao);
      Console.WriteLine("------------------------------");

      Console.ReadKey();
    }
  }
}
