using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class AnaliseDeTI : Funcionario 
    {
        public override void Reajustar()
        {
            this.Salario += 700;
        }
    }
}
