using System;

namespace Cap6_Exercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            
            // array[0] = 1
            // array[1] = 3
            // array[8] = 17
            // array[9] = 19
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = 2 * i + 1;
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
