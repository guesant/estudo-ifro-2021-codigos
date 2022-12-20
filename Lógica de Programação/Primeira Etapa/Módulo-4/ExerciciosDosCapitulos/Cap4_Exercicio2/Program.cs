using System;

namespace Cap4_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero = 5;
            int segundoNumero = 2;

        
            Console.WriteLine(primeiroNumero / segundoNumero);
            Console.WriteLine((double)primeiroNumero / segundoNumero);
            Console.WriteLine(primeiroNumero / (double)segundoNumero);
            Console.WriteLine((double)primeiroNumero / (double)segundoNumero);
            Console.WriteLine((double)(primeiroNumero / 2));

        }
    }
}
