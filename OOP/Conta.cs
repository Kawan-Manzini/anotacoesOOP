using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
     //Adicionar um modificador, se não a classe ficara vazia e não conseguiremos chama la 
    public class Conta
    {
        //Get significa pode ser acessado
        //set significa que vc pd adicionar um valor ao Saldo
        private double Saldo { get;  set; } // privou outra classe de setar um valor dentro de Saldo

        public double Limite { get; private set; }// privou set de Limite pois ja criamos um metodo para determinar um Limite 

        public int Numero { get; set; }
        //Quando instaciamos um modelo estamos criando um objeto

        // void significa que este metodo não retornará nada 
        public void Deposita(double valor)// metodo para deposito de valor 
        {
            // this é usado para manipular os valores na classe 
            this.Saldo += valor;
        }

        public void AdicionarLimite( double valor) // metodo para gerenciar o valor de limite 
        {
            this.Limite = valor;
        }

        public bool Saque(double valor)
        {
            double SaldoDisponivel = this.ConsultaSaldoDisponivel();

            if (valor > SaldoDisponivel)
            {
                Console.WriteLine("Erro na operação! Saque e Saldo indisponivel");
                return false;
            }
            this.Saldo -= valor;
            return true;
        }

        public double ConsultaSaldoDisponivel() // metodo para consulta de saldo disponivel 
        {
            //return pois usamos Double e ele precisa de um retorno diferente de void 
            return this.Saldo + this.Limite;
        }
    }
}
