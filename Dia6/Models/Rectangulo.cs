using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia6.Models
{
    partial class Rectangulo
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }

        public void Mostrar(double res)
        {
            Console.WriteLine("El resultado es: " + res);
        }

    }
}
