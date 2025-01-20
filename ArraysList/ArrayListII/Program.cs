//aula 112
using System.Collections;

Console.WriteLine("Array List II\n");

//Não ha nada para compilar, somente mostrando como funciona

var lista = new ArrayList() { "Maria", 5, true, " ", null };

lista.Add(3.5);

lista.Insert(2, "Paulo");


var lista1 = new ArrayList() { "Maria", 5, true };

int[] array1 = { 1, 2, 3 };

lista1.AddRange(array1);

lista1.InsertRange(2, array1);

Console.ReadKey();