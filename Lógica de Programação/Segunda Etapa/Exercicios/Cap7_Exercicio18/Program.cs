using System;

namespace Cap7_Exercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            double resposta1, resposta2, resposta3, resposta4, resposta5;
            
            resposta1 = calculaIRPF(1350.57);
            resposta2 = calculaIRPF(2150.37);
            resposta3 = calculaIRPF(3378.98);
            resposta4 = calculaIRPF(3956.12);
            resposta5 = calculaIRPF(6200.15);

            Console.WriteLine("IRPF 1: {0:C2}", resposta1);
            Console.WriteLine("IRPF 2: {0:C2}", resposta2);
            Console.WriteLine("IRPF 3: {0:C2}", resposta3);
            Console.WriteLine("IRPF 4: {0:C2}", resposta4);
            Console.WriteLine("IRPF 5: {0:C2}", resposta5);

            Console.ReadKey();
        }
        
        static double calculaIRPF(double renda)
        {
            if(renda <= 1710.18)
            {
                return 0;
            }
            else if(renda <= 2563.91)
            {
                return renda * 0.075 - 128.31;
            }
            else if(renda <= 3418.59)
            {
                return renda * 0.15 - 320.60;
            }
            else if(renda <= 4271.59)
            {
                return renda * 0.225 - 577.00;
            }
            else
            {
                return renda * 0.275 - 790.58;
            }
        }
    }
}
