using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aprendendo OOP");
            // Para cria um objeto, Vc precisa criar uma instância da class Conta
            // new quer dizer q quero criar uma instância 
            //Criando instância
            Conta conta1 = new Conta();

            //criando segunda instância
            Conta conta2 = new Conta();

            //Valores atribuidos a conta 1
            conta1.Saldo = 1500;
            conta1.Limite = 500;
            conta1.Numero = 123;

            // valores atribuidos a conta 2
            conta2.Saldo = 2000;
            conta2.Limite = 600;
            conta2.Numero = 456;

            Console.WriteLine("Olá, Usuário, seu saldo em conta é: " + conta1.Saldo);
            Console.WriteLine("Limite de saque é: " + conta1.Limite);
            Console.WriteLine("O numero de conta é: " + conta1.Numero) ;


            Console.WriteLine("________________________________________________________________________");

            Console.WriteLine("Olá, Usuário, seu saldo em conta é: " + conta2.Saldo);
            Console.WriteLine("Limite de saque é: " + conta2.Limite);
            Console.WriteLine("O numero de conta é: " + conta2.Numero);
        }
    }
}
