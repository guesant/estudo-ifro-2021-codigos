using System;

namespace Prova_Cap4_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double media;
            int[] valores;
            
            valores = perguntarValores(3);
            media = calcularMedia(valores);
            
            Console.WriteLine("A média entre os 3 números é " + media);
            Console.ReadKey();
        }

        static int[] perguntarValores(int quantidade) {
            int[] valores = new int[quantidade];
            
            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write($"Digite o {i + 1} valor: ");
                valores[i] = Convert.ToInt32(Console.ReadLine());
            }

            return valores;
        }
        
        static int calcularSoma(int[] valores) {
            int soma = 0;

            for(int i = 0; i < valores.Length; i++)
            {
                soma += valores[i];
            }

            return soma;
        }
        
        
        static double calcularMedia(int[] valores)
        {
            return calcularSoma(valores) / (double)valores.Length;
        }
    }
}
