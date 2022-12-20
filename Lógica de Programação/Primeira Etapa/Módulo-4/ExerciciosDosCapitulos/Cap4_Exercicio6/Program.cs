using System;

namespace Cap4_Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;

            Console.WriteLine(a > b | c < d);
            Console.WriteLine(a > b || c < d);
            Console.WriteLine(a > b & c < d);
            Console.WriteLine(a > b && c < d);
            Console.WriteLine(a > b ^ c < d);
            
            Console.ReadKey();
        }
    }
}
