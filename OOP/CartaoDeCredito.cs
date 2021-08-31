using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class CartaoDeCredito
    {
        public string Numero { get; set; }
        public string DataDeValidade { get; set; }

        //agregado cliente 
        public Cliente Cliente { get; set; }
    }
}
