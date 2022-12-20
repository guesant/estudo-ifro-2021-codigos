using System;

namespace Prova_Cap4_Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int totFuncionarios;

            Console.Write("Total de Funcionários: ");
            totFuncionarios = Convert.ToInt32(Console.ReadLine());
            
            string[] nomes = new string[totFuncionarios];
            double[] salariosAtuais = new double[totFuncionarios];
            double[] salariosReajustados = new double[totFuncionarios];

            for(int i = 0; i < nomes.Length; i++) 
            {
                Console.WriteLine("-----------------------------------");

                Console.Write($"Nome do funcionário {i+1}: ");
                nomes[i] = Console.ReadLine();

                Console.Write("Salário atual do funcionário: ");
                salariosAtuais[i] = Convert.ToDouble(Console.ReadLine());
            }

            salariosReajustados = reajustarSalarios(salariosAtuais);

            mostrarReajustes(nomes, salariosAtuais, salariosReajustados);

            Console.ReadKey();
        }
        
        static void mostrarReajustes(string[] nomes, double[] salariosAtuais, double[] salariosReajustados)
        {
            for(int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"Nome {i+1}: " + nomes[i]);
                Console.WriteLine("- Salário atual: {0:C2}", salariosAtuais[i]);
                Console.WriteLine("- Salário reajustado: {0:C2}", salariosReajustados[i]);
            }
        }

        static double[] reajustarSalarios(double[] salariosAtuais)
        {
            double[] salariosReajustados = new double[salariosAtuais.Length];

            for(int i = 0; i < salariosAtuais.Length; i++) 
            {
                salariosReajustados[i] = calcularReajuste(salariosAtuais[i]);
            }

            return salariosReajustados;
        }

        static double calcularReajuste(double salario) {
            return salario * 1.0875;
        }
    }
}
