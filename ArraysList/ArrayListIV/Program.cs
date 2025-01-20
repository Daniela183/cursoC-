//aula 114
using System.Collections;

Console.WriteLine("Array List IV\n");
//var lista = new ArrayList() { "Maria", 5, true, 4.5, null, DateTime.Now };

////Verificar de um elemento existe na coleção

//var res1 = lista.Contains(5); //true
//bool res2 = lista.Contains("Mari"); //false

//Console.WriteLine(res1);
//Console.WriteLine(res2);
//Console.WriteLine(lista.Contains(null)); //true

//Ordenação
var lista = new ArrayList() { "Maria", "Ana", "Zilda", "Carlos", "Diná" };

var tipo1 = lista[0].GetType();

var lixo = new ArrayList() { 1, 2, 3 };

var tipo2 = lixo[0].GetType();

Console.WriteLine("ArrayList original \n");
foreach (var item in lista)
{
    Console.Write($"{item} ");
}

Console.WriteLine("\nNumero de elementos no array: " + lista.Count);
lista.Clear();

Console.WriteLine("\nNumero de elementos no array depois do Clear " + lista.Count);

Console.ReadKey();