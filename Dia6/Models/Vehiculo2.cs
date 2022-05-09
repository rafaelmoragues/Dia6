using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia6.Models
{
    partial class Vehiculo
    {
        public void Apagar()
        {
            EstadoMotor = false;
            Console.WriteLine("El vehiculo NO esta en marcha");
        }

        public void Arrancar()
        {
            EstadoMotor = true;
            Console.WriteLine("El vehiculo esta en marcha");
        }
        public void Acelerar()
        {
            Velocidad = 45;
            Console.WriteLine("El vehiculo se mueve a " + Velocidad + " Km/h");
        }
        public void Frenar()
        {
            Console.WriteLine("El vehiculo se detuvo");
        }
    }
}
