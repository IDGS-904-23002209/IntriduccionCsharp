using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntriduccionCsharp.Models
{
    public class OperacionAporB
    {
        public double A { get; set; }
        public double B { get; set; }
        public double Resp { get; set; }
        public string RestSuma { get; set; }

        public void Operacion() 
        {
            for (int i = 1; i <= B; i++)
            {

                this.Resp += (double)A ;
                this.RestSuma += Convert.ToString(A);
                if(i != 20)
                {
                    this.RestSuma += " + ";
                }
            }
        }

    }
}