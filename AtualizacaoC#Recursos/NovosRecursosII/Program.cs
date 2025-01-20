// aula 253 C# 11
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Novos Recursos - II C# 11\n");

Pessoa ana = new Pessoa("Ana", 22);

Console.ReadKey();
public class Pessoa
{
    public  string? Nome { get; set; }
    public required int Idade { get; set; }

    public Pessoa() { }
    [SetsRequiredMembers]
    public Pessoa(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}