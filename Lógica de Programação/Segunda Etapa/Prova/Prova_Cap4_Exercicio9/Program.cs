using System;

namespace Prova_Cap4_Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] provas;
            double media;

            provas = perguntarNotas(3);
            media = calcularMedia(provas);

            if(media >= 7)
            {
                Console.WriteLine("Aprovado!");
            } else {
                double exame, final;

                Console.Write("Digite a nota do exame: ");
                exame = Convert.ToDouble(Console.ReadLine());

                final = calcularFinal(media, exame);

                if(final >= 5) 
                {
                    Console.WriteLine("Aprovado.");
                } 
                else {
                    Console.WriteLine("Reprovado.");
                }
            }
            Console.ReadKey();
        }

        static int[] perguntarNotas(int quantidade) {
            int[] notas = new int[quantidade];

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Digite a nota da prova {0}: ", i + 1);
                notas[i] = Convert.ToInt32(Console.ReadLine());
            }

            return notas;
        }

        static double calcularMedia(int[] provas)
        {
            double soma = 0;
            
            for (int i = 0; i < provas.Length; i++)
            {
                soma += provas[i];
            }

            return soma / provas.Length;
        }
        
        static double calcularFinal(double media, double exame)
        {
            return (media + exame) / 2;
        }
    }
}
