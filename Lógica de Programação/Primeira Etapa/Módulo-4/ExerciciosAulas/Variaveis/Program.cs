using System;

namespace Variaveis {
  class Program {
    static void Main(string[] args) {
      // declaração de variáveis com um conteúdo nulo
      double saldo = 0;
      string nome = null;
      int numeroDaConta = 0;
      bool contaAtiva = false;
      
      Console.Write("Saldo: ");
      Console.WriteLine(saldo);
      Console.Write("Nome: ");      
      Console.WriteLine(nome);
      Console.Write("Número da conta: ");      
      Console.WriteLine(numeroDaConta);
      Console.Write("Conta ativa? ");      
      Console.WriteLine(contaAtiva);
      
      Console.ReadKey(); // aguada o usuário pessionar uma tecla
      
      // gerar um número aleatório
      Random gerador = new Random();
      var numeroAleatorio = gerador.NextDouble();
      Console.WriteLine("Número aleatório: " + numeroAleatorio);
      
      Console.ReadKey(); // aguada o usuário pessionar uma tecla
      
      // converter um número extemamente longo para inteiro
      long valor_long = 19213123123123123;
      int valor_int = (int)valor_long;
      Console.WriteLine(valor_long);
      Console.WriteLine(valor_int);
      
      Console.ReadKey(); // aguada o usuário pessionar uma tecla

      // conversão de string para inteiro
      string valorString = "234";
      int valorStringInt = Convert.ToInt32(valorString);
      Console.WriteLine("Valor string: " + valorString);
      Console.WriteLine("Valor string->int: " + valorStringInt);

      // fim
      Console.WriteLine("\nPressione qualquer tecla para sair");
      Console.ReadKey();
    }
  }
}
