using System;

namespace Exercicio4_Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração das variáveis
            int valorDigitado, resultadoQuadrado, resultadoCubo;
            
            // é pedido um número inteiro ao usuário
            Console.WriteLine("Digite um número inteiro: ");
            valorDigitado = Convert.ToInt32(Console.ReadLine());

            // calcula os resultados
            resultadoQuadrado = valorDigitado * valorDigitado;
            resultadoCubo = valorDigitado * valorDigitado * valorDigitado;
            
            // mostra os resultados
            Console.WriteLine();
            Console.WriteLine(valorDigitado + " ao quadrado: " + resultadoQuadrado);
            Console.WriteLine(valorDigitado + " ao cubo: " + resultadoCubo);
            
            Console.WriteLine("\nPressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
