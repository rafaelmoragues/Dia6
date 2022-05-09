using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia6.Generics
{
     class Pilas <T>
    {
        public Stack<T> stack = new Stack<T>();

        public void Apilar(T objeto)
        {
            stack.Push(objeto);
        }

        public T desapilar ()
        {
            return stack.Pop();
        }


        public void MostrarPila()
        {
            foreach (T objeto in stack)
            {
                Console.WriteLine(objeto);
            }
            Console.WriteLine("--------------------");
        }
    }
}
