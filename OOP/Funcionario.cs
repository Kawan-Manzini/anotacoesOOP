using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
  public abstract   class Funcionario
    {
        private string Nome { get; set; }
        public double Salario { get; protected set; }    // encapsulamento: mudamos os modificadores de acesso para esconder os membros

        public abstract  void Reajustar();

        public void AdicionarNome(string primeiroNome , string sobreNome)
        {
            string nomeCompleto = primeiroNome + " " + sobreNome;
            this.Nome = nomeCompleto;
        }

        public void AdicionarSalarioPadrao(double salario)
        {
            this.Salario = salario;
        }
    }
}
