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
            Conta conta = new Conta();

            conta.AdicionarLimite(1500);

            conta.Deposita(1500);
            conta.Deposita(2500);
            conta.Deposita(4500);

           bool saca = conta.Saque(7000);

            if (saca)
            {
                //armazenando retorno do objeto em uma variavel 
                double saldo = conta.ConsultaSaldoDisponivel();

                Console.WriteLine("Seu saldo é: " + saldo);
                Console.WriteLine("Seu limite é: " + conta.Limite);
                // para set (setar um valor)  o limite esta bloqueado mas para get (buscar) esta publico 
            }


        }
    }
}
