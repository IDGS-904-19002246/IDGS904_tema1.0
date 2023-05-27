using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace IDGS904_tema1.Models
{
    public class OperasBas
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int opcion { get; set; }
        public double Res { get; set; }

        public void FIN(int n1, int n2, int op ) {
            Num1 = n1;
            Num2 = n2;
            if (op == 1) { SUM(); }
            if (op == 2) { RES(); }
            if (op == 3) { MUL(); }
            if (op == 4) { DIV(); }
        }
        public void SUM() { Res = Num1 + Num2;}
        public void RES() { Res = Num1 - Num2; }
        public void MUL() { Res = Num1 * Num2; }
        public void DIV() { Res = (double)Num1 / Num2; }
    }
}