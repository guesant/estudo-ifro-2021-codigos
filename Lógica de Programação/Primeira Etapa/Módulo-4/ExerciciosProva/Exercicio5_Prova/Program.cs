using System;

namespace Exercicio5_Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração das variávels
            int numA, numB, numC, numD;
            
            // informação ao usuário
            Console.WriteLine("\n=========================================================");
            Console.WriteLine("Após ser pedido o número, pressione enter para confirmar.");
            Console.WriteLine("=========================================================");
            Console.WriteLine(); // quebra de linha
            
            // usuário digita o número A
            Console.WriteLine("Número A: ");
            numA = Convert.ToInt32(Console.ReadLine());
            
            // usuário digita o número B
            Console.WriteLine("Número B: ");
            numB = Convert.ToInt32(Console.ReadLine());

            // usuário digita o número C
            Console.WriteLine("Número C: ");
            numC = Convert.ToInt32(Console.ReadLine());
            
            // usuário digita o número D
            Console.WriteLine("Número D: ");
            numD = Convert.ToInt32(Console.ReadLine());

            // separar o resultado xD
            Console.WriteLine("\n=================================\n");
            
            // é exibido os resultados das somas ao usuário   
            Console.WriteLine("Soma dos valores: ");      
            Console.WriteLine("A + B = " + (numA + numB));
            Console.WriteLine("A + C = " + (numA + numC));
            Console.WriteLine("A + D = " + (numA + numD));
            Console.WriteLine("B + C = " + (numB + numC));
            Console.WriteLine("B + D = " + (numB + numD));
            Console.WriteLine("C + D = " + (numC + numD));
            
            // quebra de linha
            Console.WriteLine();   
            
            // é exibido os resultados das multiplicações ao usuário   
            Console.WriteLine("Multiplicação dos valores: ");      
            Console.WriteLine("A * B = " + (numA * numB));
            Console.WriteLine("A * C = " + (numA * numC));
            Console.WriteLine("A * D = " + (numA * numD));
            Console.WriteLine("B * C = " + (numB * numC));
            Console.WriteLine("B * D = " + (numB * numD));
            Console.WriteLine("C * D = " + (numC * numD));   
            
            Console.WriteLine("\nPressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
