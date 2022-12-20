using System;

namespace Cap7_Exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            double resposta1 = calculaJurosComposto(1000, 0.1, 6);
            double resposta2 = calculaJurosComposto(2000, 0.05, 6);
            
            Console.WriteLine("Montante: " + resposta1);
            Console.WriteLine("Montante: " + resposta2);

            Console.ReadKey();
        }
        
        static double calculaJurosComposto(double capital, double taxa, int periodo)
        {
            double montante = capital * Math.Pow(1 + taxa, periodo);
            return montante;
        }
    }
}
