using System;

namespace Cap56_Exercicio10
{
  class Program
  {
    static void Main(string[] args)
    {
      double mediaA, mediaB, mediaC, mediaD, mediaE;
      uint somaA = 0, somaB = 0, somaC = 0, somaD = 0, somaE = 0;
      uint contagemA = 0, contagemB = 0, contagemC = 0, contagemD = 0, contagemE = 0;

      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine("Digite a nota do aluno {0}:", i + 1);
        uint nota = Convert.ToUInt32(Console.ReadLine());

        if (nota < 3)
        {
          somaE += nota;
          contagemE++;
        }
        else if (nota < 5)
        {
          somaD += nota;
          contagemD++;
        }
        else if (nota < 7)
        {
          somaC += nota;
          contagemC++;
        }
        else if (nota < 9)
        {
          somaB += nota;
          contagemB++;
        }
        else if (nota <= 10)
        {
          somaA += nota;
          contagemA++;
        }
      }

      mediaA = somaA / (double)contagemA;
      mediaB = somaB / (double)contagemB;
      mediaC = somaC / (double)contagemC;
      mediaD = somaD / (double)contagemD;
      mediaE = somaE / (double)contagemE;


      Console.WriteLine("A: {0} aluno(s) - Média: {1:N2}", contagemA, mediaA);
      Console.WriteLine("B: {0} aluno(s) - Média: {1:N2}", contagemB, mediaB);
      Console.WriteLine("C: {0} aluno(s) - Média: {1:N2}", contagemC, mediaC);
      Console.WriteLine("D: {0} aluno(s) - Média: {1:N2}", contagemD, mediaD);
      Console.WriteLine("E: {0} aluno(s) - Média: {1:N2}", contagemE, mediaE);

      Console.ReadKey();
    }
  }
}
