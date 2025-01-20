//aula 116
Console.WriteLine("List <T> II\n");

Console.WriteLine("Add coleção de elementos\n");
//var lista = new List<int>() { 9, 5, 4, 1, 7, 8, 3, 6, 9, 0};
//Métodos Remove, RemoveAt, RemoveRange
//lista.Remove(7);
//lista.RemoveAt(4);
//lista.RemoveRange(0,2);

Console.WriteLine("Add e insert método range\n");
//var lista = new List<string>() { "Maria", "Pedro", "Ana" };
//string[] array1 = { "Diná", "Carlos", "Pedro" };

//lista.AddRange(array1);
//lista.InsertRange(1, array1);

Console.WriteLine("Add e insert normal\n");
//lista.Add("Marta");
//lista.Insert(2, "Bia");

//Console.WriteLine(lista.Count + " itens");

Console.WriteLine("Acessando um elemento usando indice\n");
//var lista = new List<string>() { "Maria", "Pedro", "Ana", "Pedro" };
//var primeiro = lista[0];
//var quarto = lista[3];

//Console.WriteLine(primeiro);
//Console.WriteLine(quarto);

//lista[0] = "Zé";
//lista[3] = "Silvia";

//Console.WriteLine(lista[0]);
//Console.WriteLine(lista[3]);

Console.WriteLine("Interando usando o FOR\n");
//for (int i = 0; i < lista.Count; i++)
//{
//    Console.WriteLine(lista[i]);
//}
Console.WriteLine("Interando usando o FOREACH\n");
//foreach (var item in lista)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("Verificando elementos na coleção");
//var lista = new List<string>() { "Maria", "Pedro", "Ana", "Carlos", "Zé" };
//var res1 = lista.Contains("Ana");
//var res2 = lista.Contains("Zé");

//var res3 = lista.Contains("Ze");
//var res4 = lista.Contains("Mari");

//Console.WriteLine(lista.Contains("Pedro"));

Console.WriteLine("Ordenando e removendo de todos os elementos");
var lista = new List<string>() { "Maria", "Pedro", "Ana", "Carlos", "Zé" };

ExibirLista(lista);
lista.Sort();

ExibirLista(lista);
lista.Clear();
ExibirLista(lista);
Console.WriteLine(lista.Count + " itens");
Console.WriteLine("Fim");

Console.ReadKey();

static void ExibirLista(List<string> lista)
{
    Console.WriteLine();
	foreach (var item in lista)
	{
        Console.WriteLine(item);
    }
}