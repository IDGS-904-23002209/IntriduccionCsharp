using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntriduccionCsharp.Models
{
    public class Distancia
    {
        public double Numx1 { get; set; }
        public double Numy1 { get; set; }
        public double Numx2 { get; set; }
        public double Numy2 { get; set; }
        public double Res { get; set; }

        public void calcularDistancia()
        {
            double sumaCuadrados = Math.Pow(Numx2 - Numx1, 2) + Math.Pow(Numy2 - Numy1, 2);
            this.Res = Math.Sqrt(sumaCuadrados);
            
        }
    }
}