using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dia6.Models;

namespace Dia6
{
    static class Extensiones
    {
        public static string PrimerMitad( this string palabra)
        {
            string aux = palabra.Substring(0, palabra.Length /2);
            return aux;
        }

        public static string SegundaMitad(this string palabra)
        {
            string aux = palabra.Substring(palabra.Length /2, palabra.Length - (palabra.Length/2));
            return aux;
        }

        public static bool MayorEdad (this Persona per)
        {
           double aux = per.Edad();
            if(aux >= 18) { return true; }
            else { return false; }
        }

        public static void ImprimirTodo<T>(this List<T> lista)
        {
            foreach(T item in lista)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Imprimir (this int num, int fin)
        {
            for(int i = num; i <= fin; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static double Centavos(this double num)
        {
            double cent = num - Math.Truncate(num);
            return cent;
        }

        public static int Entero(this double num)
        {
            int num2 = Convert.ToInt32(num);
            return num2;
        }
    }
}
