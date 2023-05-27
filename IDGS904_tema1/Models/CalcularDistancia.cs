using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class CalcularDistancia
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public int D { get; set; }
        
        
        public double Calcular(int x1, int y1, int x2, int y2) {
            int X =  x2 - x1;
            int Y = y2 - y1;
            D = 1;
            //D = Math.Sqrt(X^2 + Y^2 );
            double res = (X * X) + (Y * Y);
            return Math.Sqrt(res);
        }

    }
}