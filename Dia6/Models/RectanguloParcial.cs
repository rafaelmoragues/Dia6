using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia6.Models
{
    partial class Rectangulo
    {
        public double RetornarPerimetro()
        {
            double res = Lado1 + Lado1 + Lado2 + Lado2;
            return res;
        }
        public double  RetormarArea()
        {
            double res = Lado1 * Lado2;
            return res;
        }
    }
}
