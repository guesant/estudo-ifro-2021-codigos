using System;

namespace Prova_Cap4_Exercicio8
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

        static void mostrarResultado(int numero) {
            string resultadoTrês, resultadoSete;
            
            resultadoTrês = resultadoParaTexto(éMúltiploDeTrês(numero));
            resultadoSete = resultadoParaTexto(éMúltiploDeSete(numero));
            
            Console.WriteLine("O número " + numero);
            Console.WriteLine("- É múltiplo de 3? " + resultadoTrês);
            Console.WriteLine("- É múltiplo de 7? " + resultadoSete);
        }

        static bool éMúltiploDeTrês(int numero)
        {
            return numero % 3 == 0;
        }
        
        static bool éMúltiploDeSete(int numero)
        {
            return numero % 7 == 0;
        }
        
        static string resultadoParaTexto(bool resultado) {
            return resultado ? "sim" : "nao";
        }
    }
}
