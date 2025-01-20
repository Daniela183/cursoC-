//aula 113
using System.Collections;

Console.WriteLine("Array List III\n");

//Não ha nada para compilar, somente mostrando como funciona

var lista = new ArrayList() { "Ana", 5, true, " ", null, 1.1, "Zé", 3, 9, null };

lista.Remove(null);

lista.RemoveAt(4);

lista.RemoveRange(0, 2);

Console.ReadKey();