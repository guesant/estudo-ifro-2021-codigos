using System;

namespace Cap6_Exercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random gerador = new Random();
            
            // cada item irá receber um valor inteiro aleatório, de 0 a 100
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(gerador.NextDouble() * 100);
            }
            
            // exibição dos valores
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }
}
