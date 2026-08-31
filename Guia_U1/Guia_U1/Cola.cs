using System;
using System.Collections.Generic;

namespace Guia_U1
{
    internal class Cola : IColleccion
    {
        private List<object> elementos = new List<object>();

        public bool EstaVacia()
        {
            return elementos.Count == 0;
        }

        public bool Añadir(object elemento)
        {
            elementos.Add(elemento);
            return true;
        }

        public object Extraer()
        {
            if (EstaVacia())
            {
                return null;
            }

            object elemento = elementos[0];
            elementos.RemoveAt(0);
            return elemento;
        }

        public object Primero()
        {
            if (EstaVacia())
            {
                return null;
            }

            return elementos[0];
        }
    }
}