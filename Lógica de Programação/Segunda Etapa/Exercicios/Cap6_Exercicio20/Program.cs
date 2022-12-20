using System;

namespace Cap6_Exercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            // array[0] = 0
            // array[1] = 1
            // array[8] = 8
            // array[9] = 9
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            
            // exibição de cada valor
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }
}
