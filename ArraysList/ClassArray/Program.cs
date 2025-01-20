//105
Console.WriteLine("Class Array\n");

string[] nomes = { "Ana", "Beatriz", "Maria", "Marta", "Paulo", "Carlos" };
Console.WriteLine("---Exibindo o array original---");

ExibirArray(nomes);

Console.WriteLine("\n\n---Invertendo o array---");
Array.Reverse(nomes);
ExibirArray(nomes);

Console.WriteLine("\n\n---Ordemando o array---");
Array.Sort(nomes);
ExibirArray(nomes);

Console.WriteLine("\n\nLocalizando um item no array");
Console.Write("Informe o nome: ");

string nome = Console.ReadLine();
var indice = Array.BinarySearch(nomes, nome);

if(indice >= 0 )
    Console.WriteLine($"\n{nome} foi encontrado com o indice = {indice}");
else
    Console.WriteLine($"\n{nome} não foi encontrado");

Console.ReadKey();

static void ExibirArray(string[] nomes)
{
    foreach (var nome in nomes)
    {
        Console.Write($"{nome} ");
    }
}