using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class GerenteDeAgencia : Gerente 
    {
        public override void Reajustar()
        {
            this.Salario += 1500;
        }
    }
}
