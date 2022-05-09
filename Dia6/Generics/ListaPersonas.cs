using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dia6.Models;

namespace Dia6.Generics
{
    class ListaPersonas : IListaDevPlace<Persona>
    {
        List<Persona> lista = new List<Persona>();
        public void AgregarItem(Persona item)
        {
            lista.Add(item);
        }

        public void BorrarItem(Persona item)
        {
             lista.Remove(item);
        }

        public int CantidadItems()
        {
            return lista.Count;
        }

        public Persona ObtenerItem(int index)
        {
            return lista[index];
        }
    }
}
