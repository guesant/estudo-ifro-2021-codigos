using System;

namespace Aula_67
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] notas = new int[3][];

            for(int i = 0; i < notas.Length; i++)
            {
                notas[i] = new int[3];
                
                Console.WriteLine($"Aluno {i + 1} ");
                
                for(int j = 0; j < notas[i].Length; j++)
                {
                    Console.Write($"- Nota {j+1}: ");
                    notas[i][j] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("-----------------");
            }


            // Desafío do Exercício
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Apresentação dos Resultados:");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");

            Console.WriteLine("* | Nota 1 | Nota 2 | Nota 3");

            for(int i = 0; i < notas.Length; i++)
            {
                // número do aluno atual
                Console.Write(i + 1);

                // mostra cada nota do aluno atual
                for(int j = 0; j < notas[i].Length; j++)
                {
                    // nota "j" do aluno "i"
                    Console.Write(" | " + Convert.ToString(notas[i][j]).PadLeft(6));
                }

                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
