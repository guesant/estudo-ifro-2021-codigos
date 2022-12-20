using System;

namespace Exercicio3_Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração das variáveis
            int celsius, fahrenheit;
            
            // é pedido ao usuário os graus celsius            
            Console.WriteLine("Graus Celsius (digite e pressione enter): ");
            celsius = Convert.ToInt32(Console.ReadLine());
            
            // aqui é calculado o resultado em fahrenheit com a fórmula proposta
            fahrenheit = (9 * celsius + 160) / 5;
            
            // mostra o resultado ao usuário
            Console.WriteLine("\n=================================\n");
            Console.WriteLine(celsius + " ºC = " + fahrenheit + " ºF"); // exemplo: 10 ºC = 50 ºF
            Console.ReadKey();
        }
    }
}
