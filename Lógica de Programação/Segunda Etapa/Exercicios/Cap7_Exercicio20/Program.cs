using System;

namespace Cap7_Exercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[2] {
                "Amanda",
                "Joyce"
            };

            double[] imcs = new double[2] {
                calculaIMC(52.6, 1.61),
                calculaIMC(54.1, 1.59)
            };

            string[] situacoes = new string[2] {
                calculaResultadoIMC(imcs[0]),
                calculaResultadoIMC(imcs[1])
            };
            

            for (int i = 0; i < nomes.Length; i++)
            {
                double imc;
                string nome, situacao;
                
                imc = imcs[i];
                nome = nomes[i];
                situacao = situacoes[i];

                Console.WriteLine($"IMC de {nome}: {imc} - {situacao}");
            }
            Console.ReadKey();
        }

        static double calculaIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        static string calculaResultadoIMC(double imc)
        {
            if(imc < 17)
            {
                return "Muito abaixo do peso";
            }
            else if(imc < 18.5)
            {
                return "Abaixo do peso";
            }
            else if(imc < 25)
            {
                return "Peso normal";
            }
            else if(imc < 30)
            {
                return "Acima do peso";
            }
            else if(imc < 35)
            {
                return "Obesidade I";
            }
            else if(imc < 40)
            {
                return "Obesidade II - severa";
            }
            else
            {
                return "Obesidade III - mórbida";
            }
        }
    }
}
