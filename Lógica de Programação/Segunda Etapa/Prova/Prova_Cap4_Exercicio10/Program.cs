using System;

namespace Prova_Cap4_Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int parcelas;
            double valorTotal;

            Console.Write("Digite o valor total: ");
            valorTotal = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Quantidade de parcelas [1/3/5/10]: ");
            parcelas = Convert.ToInt32(Console.ReadLine());
        
            mostrarResultado(valorTotal, parcelas);
            Console.ReadKey();
        }

        static void mostrarResultado(double valorTotal, int parcelas)
        {
            double valorResultante, valorPorParcela;

            valorResultante = calcularValorResultante(valorTotal, parcelas);
            valorPorParcela = valorResultante / parcelas;
            
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Valor Resultante: {0:C2}", valorResultante);
            Console.WriteLine("{0} parcela(s) com um valor de {1:C2} cada.", parcelas, valorPorParcela);
        }

        static double calcularValorResultante(double valorTotal, int parcelas)
        {
            double valorResultante;
            valorResultante = valorTotal * porcentagemPorParcela(parcelas);
            return valorResultante;
        }

        static double porcentagemPorParcela(int parcelas) {
            if(parcelas == 1)
            {
                return 1 - 0.05;
            }
            else if(parcelas == 3)
            {
                return 1;
            }
            else if(parcelas == 5)
            {
                return 1 + 0.02;
            }
            else if(parcelas == 10)
            {
                return 1 + 0.08;
            }

            // por padrão vai ser o preço sem alteração.
            return 1;
        }
    }
}
