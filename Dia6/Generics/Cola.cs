using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia6.Generics
{
    internal class Cola<T>
    {
        Queue<T> queue = new Queue<T>();

        public void Encolar(T Objeto)
        {
            queue.Enqueue(Objeto);
        }

        public T Desencolar()
        {
            return queue.Dequeue();
        }

        public void MostrarCola()
        {
            foreach (T objeto in queue)
            {
                Console.WriteLine(objeto);
            }
            Console.WriteLine("--------------------");
        }
    }
}
