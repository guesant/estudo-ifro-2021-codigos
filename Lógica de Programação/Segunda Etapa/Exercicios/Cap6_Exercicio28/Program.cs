using System;

namespace Cap6_Exercicio28
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];
            
            // cada item da array conterá outra array com 3 itens
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = new int[3];
            }
            
            // atribuição dos valores
            array[0][0] = 19;
            array[0][1] = 22;
            array[0][2] = 31;
            array[1][0] = 2;
            array[1][1] = 51;
            array[1][2] = 12;
            array[2][0] = 41;
            array[2][1] = 11;
            array[2][2] = 3;
            
            // exibição de cada valor
            for(int i = 0; i < array.Length; i++){
                for(int j = 0; j < array[i].Length; j++)
                {
                    Console.WriteLine(array[i][j]);
                }
            }

            Console.ReadKey();
        }
    }
}
