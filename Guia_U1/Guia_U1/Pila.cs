using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_U1
{
    public class Pila : IColleccion
    {
        private object[] elementos;
        private int cantidad;

        public Pila(int capacidad)
        {
            elementos = new object[capacidad];
            cantidad = 0;
        }
        public bool EstaVacia()
        {
            return cantidad == 0;
        }
        public bool Añadir(object elemento)
        {
            if (cantidad < elementos.Length)
            {
                elementos[cantidad] = elemento;
                cantidad++;
                return true;
            }
            return false;
        }
        public object Primero()
        {
            if (EstaVacia())
            {
                return null;
            }

            return elementos[cantidad - 1];
        }

        public object Extraer()
        {
            if (EstaVacia())
            {
                return null;
            }
            cantidad--;
            object elemento = elementos[cantidad];
            elementos[cantidad] = null; // Limpiar la referencia
            return elemento;
        }
    }
}