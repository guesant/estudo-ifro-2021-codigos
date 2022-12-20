using System;

namespace Prova_Cap4_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            vendaProduto();
            Console.ReadKey();
        }

        static void vendaProduto() {
            string codigo, nome;
            double quantidade, valorUnitario;
            
            Console.Write("Código do Produto: ");
            codigo = Console.ReadLine();
            
            Console.Write("Nome do Produto: ");
            nome = Console.ReadLine();

            Console.Write("Valor Unitário do Produto: ");
            valorUnitario = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Quantidade comprada: ");
            quantidade = Convert.ToDouble(Console.ReadLine());

            apresentarVenda(codigo, nome, quantidade, valorUnitario);
        }
        
        static double calcularVenda(double valorUnitario, double quantidade)
        { 
            return valorUnitario * quantidade;
        }
        
        static void apresentarVenda(string codigo, string nome, double quantidade, double valorUnitario) {
            double valorResultante = calcularVenda(valorUnitario, quantidade);
            
            Console.WriteLine("--------------------------");
            Console.WriteLine("- Código: " + codigo);
            Console.WriteLine("- Produto: " + nome);
            Console.WriteLine("- Valor Unitário: {0:C2}", valorUnitario);
            Console.WriteLine("--------------------------");
            Console.WriteLine("- Quantidade: {0:N2}", quantidade);
            Console.WriteLine("- Valor Resultante: {0:C2}", valorResultante);
            Console.WriteLine("--------------------------");
        }
    }
}
