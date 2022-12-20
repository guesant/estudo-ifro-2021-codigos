using System;

namespace Cap6_Exercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
        
            // array[0] = 9
            // array[1] = 8
            // array[8] = 1
            // array[9] = 0
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = array.Length - 1 - i;
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
