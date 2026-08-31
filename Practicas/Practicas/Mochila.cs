using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    public class Mochila : IContenedor
    {
        private object[] elementos;
        private int cantidad;

        public Mochila(int capacidad)
        {
            elementos = new object[capacidad];
            cantidad = 0;
        }
       public int Contar()
        {
            return cantidad;
        }
        public bool EstaLlena()
        {
            return cantidad == elementos.Length;
        }
        public bool Guardar(object elemento)
        {
            if (!EstaLlena())
            {
                elementos[cantidad] = elemento;
                cantidad++;
                return true;
            }
            return false;
        }
        public object Sacar()
        {
            if (cantidad > 0)
            {
                cantidad--;
                return elementos[cantidad];
            }
            return null;
        }
    }

}
