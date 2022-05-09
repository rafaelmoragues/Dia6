using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dia6.Models;

namespace Dia6.Generics
{
    class ListaDeCasas : IListaDevPlace<Casa>
    {
        List<Casa> lista = new List<Casa>();
        public void AgregarItem(Casa item)
        {
            lista.Add(item);
        }

        public void BorrarItem(Casa item)
        {
            lista.Remove(item);
        }

        public int CantidadItems()
        {
            return lista.Count;
        }

        public Casa ObtenerItem(int index)
        {
            return lista[index];
        }
    }
}
