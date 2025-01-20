//aula 117
using System.Collections;

Console.WriteLine("List e ArrayList\n");

ArrayList lista = new ArrayList();
lista.Add(3);
lista.Add(4);

var elemento = lista[0];
int numero = (int)elemento;

Console.WriteLine(numero);

List<int> lista1 = new List<int>();
lista1.Add(1);

var item = lista1[0];

Console.ReadKey();