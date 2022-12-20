using System;

namespace Exercicio1_Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarando as variáveis
            int num1, num2, resultado;
            
            // usuário digita o primeiro número
            Console.WriteLine("Digite o primeiro número e depois pressione enter:");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            // usuário digita o segundo número            
            Console.WriteLine("Digite o segundo número e depois pressione enter:");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            // o resultado da soma é atribuido a variável resultado
            resultado = num1 + num2;
            
            // é mostrado ao usuário o resultado
            // Exemplo: "A soma de 10 + 20 é igual a 30"
            Console.WriteLine("A soma de " + num1 + " + " + num2 + " é igual a " + resultado);
            
            // para evitar que o console abra e feche rapidamente
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
