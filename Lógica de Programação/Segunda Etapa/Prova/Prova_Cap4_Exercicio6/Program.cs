using System;

namespace Prova_Cap4_Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            
            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            mostrarResultado(numero);
            
            Console.ReadKey();
        }

        static void mostrarResultado(int numero)
        {
            Console.WriteLine(textoResultado(numero));
        }
        
        static string textoResultado(int numero)
        {
            if(éPar(numero))
            {
                return "É par";
            }
            else
            {
                return "É ímpar";
            }
        }
        
        static bool éPar(int numero) {
            return numero % 2 == 0;
        }
    }
}
