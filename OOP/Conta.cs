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
        public double Saldo { get; set; }

        public double Limite { get; set; }

        public int Numero { get; set; }
        //Quando instaciamos um modelo estamos criando um objeto
    }
}
