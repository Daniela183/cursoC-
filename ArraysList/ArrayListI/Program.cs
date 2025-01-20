//aula 111
using System.Collections;

Console.WriteLine("Array List I\n");
//Não ha nada para compilar, somente mostrando como funciona
//Todos são a mesma coisa, porém uns mais complexos e outros simplificados
ArrayList lista;
lista = new ArrayList();

ArrayList lista1 = new ArrayList();
var lista2 = new ArrayList();
ArrayList lista3 = new();

ArrayList lista4 = new ArrayList(5);
var lista5 = new ArrayList(5);
ArrayList lista6 = new(5);

//Declarando e criando instância
ArrayList lista7 = new();

lista7.Add("Paulo");
lista7.Add(4.5);
lista7.Add(5);
lista7.Add(true);
lista7.Add("");
lista7.Add(null);

var lista8 = new ArrayList(){"Paulo", 4.5,  5, true, "", null};

Console.ReadKey();