using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas
{
    public class Pila2 : IColleccion //nombramos la clase Pila2 que implementa la interfaz IColleccion
    {
        private object[] elementos; //arreglo de objetos que representa los elementos de la pila
        private int cantidad; //    variable que representa la cantidad de elementos en la pila
        public Pila2(int capacidad)   // declaramos la clase Pila2 con un constructor que recibe la capacidad de la pila
        {
            elementos = new object[capacidad];  //inicializamos el arreglo de elementos con la capacidad especificada
            cantidad = 0; -//   inicializamos la cantidad de elementos en 0
        }
        public bool EstaVacia() // método que devuelve true si la pila está vacía y false en caso contrario
        {
            return cantidad == 0;
        }
        public bool Añadir(object elemento)   //método que añade un elemento a la pila y devuelve true si se pudo añadir y false en caso contrario
        {
            if (cantidad < elementos.Length) // si la cantidad de elementos es menor que la capacidad de la pila
            { 
                elementos[cantidad] = elemento; // añadimos el elemento al arreglo de elementos en la posición cantidad
                cantidad++;      // incrementamos la cantidad de elementos en 1
                return true;    // devolvemos true indicando que se pudo añadir el elemento
            } 
            return false; // devolvemos false indicando que no se pudo añadir el elemento
        }
        public object Extraer()  //método que extrae el último elemento añadido a la pila y lo devuelve, o null si la pila está vacía
        {
            if (!EstaVacia())       // si la pila no está vacía
            {
                cantidad--;        // decrementamos la cantidad de elementos en 1
                return elementos[cantidad];  // devolvemos el último elemento añadido a la pila    
            }
            return null; // devolvemos null indicando que la pila está vacía
        }
        public object Primero() //método que devuelve el último elemento añadido a la pila sin extraerlo, o null si la pila está vacía
        {
            if (!EstaVacia()) //    si la pila no está vacía
            {
                return elementos[cantidad - 1]; //  devolvemos el último elemento añadido a la pila sin extraerlo    
            }
            return null; // devolvemos null indicando que la pila está vacía
        }
        
       
    }
}