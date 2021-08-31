using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class ContaPoupanca : Conta, IConta //não precisamos assinar os contrator da interface pois a classe conta ja esta fazendo isso e estamos herdando dela
    {
                            //passando estes valores como parametro, para preencher o próximo construtor
        public ContaPoupanca(int numero, double limite) : base(numero, limite ) //base significa que queremos pegar nosso construtor da classe herança 
        {        
        }

        public void MostrarNumeroDaConta()
        {
            Console.WriteLine("A conta poupança é: " + this.Numero);
        }

        public override bool Saque(double valor)
        { 
           bool deuCertoSaque = base.Saque(valor);

            if (deuCertoSaque)
            {
                this.Saldo -= 6;
            }
            return false;
        }
    }
}
