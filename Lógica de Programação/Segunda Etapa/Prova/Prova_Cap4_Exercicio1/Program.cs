using System;

namespace Prova_Cap4_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma;
            int[] valores;

            valores = perguntarValores(4);
            soma = calcularSoma(valores);
            
            mostrarValores(valores);
            Console.WriteLine("A soma entre os 4 valores digitados é " + soma);

            Console.ReadKey();
        }

        static void mostrarValores(int[] valores) {
            Console.WriteLine("-------------------");
            for(int i = 0; i < valores.Length; i++)
            {
                Console.Write($"{i + 1} valor: ");
                Console.WriteLine(valores[i]);
            }
            Console.WriteLine("-------------------");
        }

        static int[] perguntarValores(int quantidade) {
            int[] valores = new int[quantidade];
            
            for(int i = 0; i < valores.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º valor: ");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }

            return valores;
        }

        static int calcularSoma(int[] valores) {
            int soma = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                soma += valores[i];
            }
            
            return soma;
        }
    }
}
