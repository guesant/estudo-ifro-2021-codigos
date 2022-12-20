using System;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int umMaisUm = 1 + 1;
            int tresVezesDois = 3 * 2;
            double quatroDivididoPorDois = 4.00 / 3.00;
            int seisModuloCinco = 20 % 2;
            
            int x = 7;
            x = x + 1 * 2;
            x = x - 4;
            x = x / (6 - 2 + (3*5) / (16 - 1));
            
            Console.WriteLine(umMaisUm);
            Console.WriteLine(tresVezesDois);
            Console.WriteLine(quatroDivididoPorDois);
            Console.WriteLine(seisModuloCinco);
            Console.WriteLine(x);

            
            Console.WriteLine("pressione uma tecla...");
            Console.ReadKey();
            Console.WriteLine();
            
            //
            
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(25));
            

            Console.WriteLine("pressione uma tecla...");
            Console.ReadKey();
            Console.WriteLine();
            
            //
            int a = 5;
            int b = 2;

            double aDouble = 5;
            double bDouble = 2;
            
            Console.WriteLine(a / b);
            Console.WriteLine((double)a / b);
            Console.WriteLine((double)a / (double)b);
            Console.WriteLine((double)a / (double)b);
            Console.WriteLine(aDouble / bDouble);

            //            
            
            Console.WriteLine("pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
