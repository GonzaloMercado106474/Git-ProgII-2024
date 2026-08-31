// See https://aka.ms/new-console-template for more information
using Guia_U1;

Console.WriteLine("Hello, World!");

Cola c = new Cola();

Console.WriteLine(c.EstaVacia());   // esperado: True

c.Añadir("A");
c.Añadir("B");
c.Añadir("C");

Console.WriteLine(c.EstaVacia());   // esperado: False
Console.WriteLine(c.Primero());     // esperado: A
Console.WriteLine(c.Extraer());     // esperado: A
Console.WriteLine(c.Extraer());     // esperado: B
Console.WriteLine(c.Extraer());     // esperado: C
Console.WriteLine(c.EstaVacia());   // esperado: True