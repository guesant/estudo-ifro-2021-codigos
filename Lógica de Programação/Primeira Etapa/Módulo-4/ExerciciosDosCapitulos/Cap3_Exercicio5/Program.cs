using System;

namespace Cap3_Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 2147483648L;
            
            int b = (int)a;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
