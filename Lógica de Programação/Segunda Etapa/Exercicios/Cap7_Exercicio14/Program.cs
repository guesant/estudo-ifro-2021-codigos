using System;

namespace Cap7_Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double resposta1 = litroPorKilometro(131.679, 13.5);
            double resposta2 = litroPorKilometro(251.856, 21.6);

            Console.WriteLine("Consumo 1: " + resposta1);
            Console.WriteLine("Consumo 2: " + resposta2);

            Console.ReadKey();
        }

        static double litroPorKilometro(double distanciaTotal, double combustivelQueimado) 
        {
            double consumo = distanciaTotal / combustivelQueimado;
            return consumo;
        }
    }
}
