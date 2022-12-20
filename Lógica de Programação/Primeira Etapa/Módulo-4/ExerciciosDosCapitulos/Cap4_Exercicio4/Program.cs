using System;

namespace Cap4_Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            Console.WriteLine(numero);
            
            numero += 2;
            Console.WriteLine(numero);

            numero -= 1;
            Console.WriteLine(numero);
            
            numero *= 3;
            Console.WriteLine(numero);
            
            numero /= 2;
            Console.WriteLine(numero);
            
            numero %= 2;
            Console.WriteLine(numero);
            
            Console.ReadKey();
        }
    }
}
