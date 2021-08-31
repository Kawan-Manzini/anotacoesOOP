using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
   public interface IConta
    {
        public void Deposita(double valor);
        public void AdicionarLimite(double valor);
        public bool Saque(double valor);
        public double ConsultaSaldoDisponivel(); 
    }
}
