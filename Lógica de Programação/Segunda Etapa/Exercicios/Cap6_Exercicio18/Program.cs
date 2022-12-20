using System;

namespace Cap6_Exercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração da array
            int[] array = new int[10];
            
            // atribuição de valores por índice
            array[0] = 57;
            array[1] = 436;
            array[2] = 724;
            array[3] = 564;
            array[4] = 245;
            array[5] = 47;
            array[6] = 34;
            array[7] = 1;
            array[8] = 347735;
            array[9] = 83;
            
            // exibição de cada valor
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            
            Console.ReadKey();
        }
    }
}
