using System;

namespace Operadores_Atribuicao
{
    class Atribuicao
    {
        static void Main(string[] args)
        {
            int valor = 1;
            Console.WriteLine(valor);
        
            valor = valor + 2;
            Console.WriteLine(valor);
            
            valor += 2;
            Console.WriteLine(valor);
            
            valor = valor - 1;
            Console.WriteLine(valor);

            valor -= 1;
            Console.WriteLine(valor);
            
            valor = valor * 6;
            Console.WriteLine(valor);
            
            valor *= 6;
            Console.WriteLine(valor);
            
            valor = valor / 3;
            Console.WriteLine(valor);
        
            valor /= 3;
            Console.WriteLine(valor);
            
            valor = valor % 3;
            valor = valor + 1;
            
            // o operador ++ acrescenta 1
            valor++;
            valor++;
            valor++;
            
            // o operador -- decrementa 1
            // valor--;
            Console.WriteLine(valor);

            Console.ReadKey();
        }
    }
}
