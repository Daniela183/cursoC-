//aula 106
using System;

Console.WriteLine("Exercícios - Arrays\n");

//Criar os arrays e alocando mem
string[] nomes = new string[5];
double[] notas = new double[5];

Console.WriteLine("Alunos\n");

//Recebendo via teclado
for (int i = 0; i < 5; i++)
{
    Console.Write("Informe o nome do aluno: ");
    string? nome = Console.ReadLine();
    nomes[i] = nome;
}
Console.WriteLine();
for (int i = 0; i < 5; i++)
{
    Console.Write("Informe a nota do aluno: ");
    double nota = Convert.ToDouble(Console.ReadLine());
    notas[i] = nota;
}

Console.WriteLine("\nAlunos:");
foreach (string nome in nomes)
{
    Console.Write($"{nome} ");
}

Console.WriteLine("\n\nNotas:");
var somaNotas = 0.0;
var totalNotas = notas.Count();

foreach (double nota in notas)
{
    somaNotas += nota;
    Console.Write($"{nota} ");
}
Console.WriteLine($"\n\nMédia Aritmética: {somaNotas / totalNotas} ");

Console.ReadKey();
