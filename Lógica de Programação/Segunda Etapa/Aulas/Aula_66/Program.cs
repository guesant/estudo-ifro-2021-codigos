using System;

namespace Aula_66
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] notas = new int[42][];
            
            // Aluno 1
            notas[0] = new int[3];
            
            // Aluno 1 - Nota 1
            Console.WriteLine("Digite a 1ª nota do 1º aluno");
            notas[0][0] = Convert.ToInt32(Console.ReadLine());
            
            // Aluno 1 - Nota 2
            Console.WriteLine("Digite a 2ª nota do 1º aluno");
            notas[0][1] = Convert.ToInt32(Console.ReadLine());

            // Aluno 1 - Nota 3
            Console.WriteLine("Digite a 3ª nota do 1º aluno");
            notas[0][2] = Convert.ToInt32(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
