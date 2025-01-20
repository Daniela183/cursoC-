//aula 151
using System.Collections;
Console.WriteLine("Análise I\n");

ArrayList lista = new ArrayList
{
    50,  //cast boxing
    "Generics", //cast
    new Aluno()
};

foreach (var obj in lista)
{
Console.WriteLine(obj);  //unboxing
}

Console.ReadLine();

public class Aluno
{
    public string? Nome { get; set; }
}