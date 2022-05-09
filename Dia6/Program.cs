using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dia6.Models;
using Dia6.Generics;

namespace Dia6
{
    internal class Program
    {
        void Opciones()
        {

            Program p1 = new Program();
            Console.WriteLine("Ingrese el numero de ejercicio a ejecutar:");
            string op = Console.ReadLine();

            if (Int32.TryParse(op, out int opcion))
            {
                switch (opcion)
                {
                    case 1:
                       Rectangulo rec = new Rectangulo();
                        double res;
                        rec.Lado1 = 40;
                        rec.Lado2 = 50;
                        res = rec.RetormarArea();
                        rec.Mostrar(res);
                        res = rec.RetornarPerimetro();
                        rec.Mostrar(res);
                        break;
                    case 2:
                       Vehiculo vehiculo = new Vehiculo();
                        vehiculo.Arrancar();
                        vehiculo.Acelerar();
                        vehiculo.Frenar();
                        vehiculo.Apagar();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese nombre");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese fecha de nacimiento en el siguiente formato:");
                        Console.WriteLine("Dia/Mes/Año");
                        string fechaAux = Console.ReadLine();
                        DateTime fecha = DateTime.ParseExact(fechaAux, "dd/MM/yyyy", null);
                        Persona p = new Persona(nombre,fecha);
                        p.Edad();
                        break;
                    case 4:
                        //Ejercicio4();
                        break;
                    case 5:
                        Pilas<String> pilas = new Pilas<String>();
                        pilas.Apilar("Hola");
                        pilas.Apilar("Estoy");
                        pilas.Apilar("Cansado");
                        pilas.MostrarPila();

                        Pilas<double> pilas1 = new Pilas<double>();
                        pilas1.Apilar(3.50);
                        pilas1.Apilar(568.45);
                        pilas1.Apilar(984);
                        pilas1.MostrarPila();
                        pilas1.desapilar();
                        pilas1.MostrarPila();
                        break;
                    case 6:
                        Cola<String> cola = new Cola<String>();
                        cola.Encolar("jorge");
                        cola.Encolar("Agustin");
                        cola.Encolar("Marcos");
                        cola.MostrarCola();
                        break;
                    case 8:
                        string rafa = "Rafael";
                        Console.WriteLine(rafa);
                        Console.WriteLine(rafa.PrimerMitad());
                        Console.WriteLine(rafa.SegundaMitad());
                        break;
                    case 9:
                        Console.WriteLine("Ingrese nombre");
                        string nombre2 = Console.ReadLine();
                        Console.WriteLine("Ingrese fecha de nacimiento en el siguiente formato:");
                        Console.WriteLine("Dia/Mes/Año");
                        string fechaAux2 = Console.ReadLine();
                        DateTime fecha2 = DateTime.ParseExact(fechaAux2, "dd/MM/yyyy", null);
                        Persona p9 = new Persona(nombre2, fecha2);
                        if (p9.MayorEdad())
                        {
                            Console.WriteLine("Es mayor de edad");
                        }
                        else
                            Console.WriteLine("Es menor de edad");
                        break;
                    case 11:
                        Console.WriteLine("Ingrese num1");
                        int num1 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese num2");
                        int num2 = Int32.Parse(Console.ReadLine());
                        num1.Imprimir(num2);
                        break;

                }
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Opciones();
            string op;
            do
            {
                Console.WriteLine("Desea ejecutar otro ejercicio? s/n");
                op = Console.ReadLine();
                if (op == "s")
                    program.Opciones();
            }
            while (op == "s");
        }
    }
}
