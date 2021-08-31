using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
   public class ContaCorrente : Conta , IConta //não precisamos assinar os contrator da interface pois a classe conta ja esta fazendo isso e estamos herdando dela
    {
        public ContaCorrente(int numero, double limite) : base(numero, limite)
        {
        }
        public void MostrarNumeroDaConta()
        {
            Console.WriteLine("A conta corrente  é: " + this.Numero);
        }
    }
}
