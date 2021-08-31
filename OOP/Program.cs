using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aprendendo OOP");

            AnaliseDeTI analiseDeTI = new AnaliseDeTI();

            analiseDeTI.AdicionarNome("kawan", "Manzini");
            analiseDeTI.AdicionarSalarioPadrao(1000);

            analiseDeTI.Reajustar();


            Console.WriteLine("Salário é: " + analiseDeTI.Salario) ;
           
            
            
            
            
            
            
            
            //ContaPoupanca contaPoupanca = new ContaPoupanca(111, 0);

            //contaPoupanca.Deposita(100);
            //contaPoupanca.Saque(10);
            //double saldoPoupança = contaPoupanca.ConsultaSaldoDisponivel();

            //Console.WriteLine("SALDO Poupança é: " + saldoPoupança);

         


            //ContaCorrente contaCorrente = new ContaCorrente(123, 100);

            //contaCorrente.Deposita(100);
            //contaCorrente.Saque(20);
            //double saldoCorrente = contaCorrente.ConsultaSaldoDisponivel();

            //Console.WriteLine("SALDO Corrente é: " + saldoCorrente);

           







            //AnaliseDeTI analiseDeTI = new AnaliseDeTI();
            //Gerente gerente = new Gerente();
            //GerenteDeAgencia gerenteDeAgencia = new GerenteDeAgencia();
            //GerenteDeTI gerenteDeTI = new GerenteDeTI();

            //analiseDeTI.Nome = "Acaciano";
            //analiseDeTI.Salario = 3000;

            //Console.WriteLine("Salario do Analista de TI é: " + analiseDeTI.Salario);

            //analiseDeTI.Reajustar();

            //Console.WriteLine("Salario do Analista de TI Reajustado é: " + analiseDeTI.Salario);

            //Console.WriteLine("___________________________________________________________________________");

            //gerente.Nome = "Junior";
            //gerente.Salario = 8000;

            //Console.WriteLine("Salario do Gerente é: " + gerente.Salario);

            //gerente.Reajustar();

            //Console.WriteLine("Salario do Gerente é: " + gerente.Salario);

            //Console.WriteLine("____________________________________________________________________________");

            //gerenteDeAgencia.Nome = "Julia";
            //gerenteDeAgencia.Salario = 10000;

            //Console.WriteLine("Salario do Gerente de Agencia é: " + gerenteDeAgencia.Salario);

            //gerenteDeAgencia.Reajustar();

            //Console.WriteLine("Salario do Gerente de Agencia é: " + gerenteDeAgencia.Salario);

            //Console.WriteLine("____________________________________________________________________________");

            //gerenteDeTI.Nome = "Joao";
            //gerenteDeTI.Salario = 20000; 

            //Console.WriteLine("Salario do Gerente de TI é: " + gerenteDeTI.Salario);

            //gerenteDeTI.Reajustar();

            //Console.WriteLine("Salario do Gerente de TI é: " + gerenteDeTI.Salario);

            //Console.WriteLine("____________________________________________________________________________");








            /*  ContaPoupanca contaPoupança = new ContaPoupanca(001, 0);

              contaPoupança.Deposita(100);
              contaPoupança.Saque(10);

            double saldo = contaPoupança.ConsultaSaldoDisponivel();

              Console.WriteLine("Saldo da conta poupança é: " + saldo);

              Conta conta = new Conta(113, 100);

              conta.Deposita(500);
              conta.Saque(140);

              double SaldoContaCorrente = conta.ConsultaSaldoDisponivel();
              Console.WriteLine("Saldo da conta corrente é: " + SaldoContaCorrente);
              */











            /* Conta conta1 = new Conta(123, 500);
            Conta conta2 = new Conta(456, 800);
            Conta conta3 = new Conta(789, 900);
            Conta conta4 = new Conta(921, 1000);

            Console.WriteLine("Total de contas: " + Conta.TotalContasCriadas);

            int total = Conta.ProximoTotalContasCriadas();

            Console.WriteLine("Proximo total de contas: " + total);*/











            /*
            //criando um objeto de cada classe
            CartaoDeCredito cdc = new CartaoDeCredito();
            Cliente c = new Cliente();

            //Adicionando o nome do cliente 
            c.nome = "Kawan Manzini";

            //Adicionando numero e data de validade do cartao
            cdc.Numero = "40088922";
            cdc.DataDeValidade = "02/2025";
            //agregando cliente ao cartão de crédito
            cdc.Cliente = c;


            Console.WriteLine("O nome do cliente é: " + c.nome);
            Console.WriteLine("O numero do cartão é: " + cdc.Numero);
            Console.WriteLine("A data de validade do cartão é: " + cdc.DataDeValidade);
            Console.WriteLine("O nome do cliente agregado é: " + cdc.Cliente.nome) ;
            */









            // Para cria um objeto, Vc precisa criar uma instância da class Conta
            // new quer dizer q quero criar uma instância 
            //Criando instância
            /*Conta conta = new Conta(40028922, 300) ;

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
                Console.WriteLine("O numero da conta é:" + conta.Numero);
            */

        }


    }
    }

