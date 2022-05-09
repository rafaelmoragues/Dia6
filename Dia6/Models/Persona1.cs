using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia6.Models
{
    partial  class Persona
    {
        public double Edad()
        {
            DateTime Actual = DateTime.Now;
            TimeSpan resta = Actual - FechaNac;
            double dias = resta.TotalDays;
            double años = Math.Floor(dias / 365);

            Console.WriteLine("La edad de la persona es: " + años + " años");
            return años;
        }

    }
}
