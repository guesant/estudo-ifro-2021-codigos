using System;

namespace Prova_Cap4_Exercicio7
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
            if(éZero(numero)) {
                return "É zero";
            } 
            else if(éPar(numero))
            {
                return "É par";
            }
            else
            {
                return "É ímpar";
            }
        }
        
        static bool éZero(int numero) {
            return numero == 0;
        }

        static bool éPar(int numero) {
            return numero % 2 == 0;
        }
    }
}
