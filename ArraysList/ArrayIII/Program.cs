//aula 104
Console.WriteLine("Array III - FOREACH");

int[] numeros;
numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

string[] nomes = { "Ana", "Maria", "Dinair", "Paulo", "Carlos" };

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Elemento do índice {i}: {numeros[i]}");
}
Console.WriteLine();
for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"Elemento do índice {i}: {nomes[i]}");
}
Console.WriteLine();
foreach (int numero in numeros)
{
    //Console.WriteLine(numero); //Um abaixo do outro
    Console.Write($"{numero} "); //Um do lado do outro
}
Console.WriteLine();
foreach (var nome in nomes)
{
    Console.Write($"{nome} ");
}

Console.ReadKey();