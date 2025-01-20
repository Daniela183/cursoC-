
Console.WriteLine("Exercício 08\n");
Console.WriteLine("Na linguagem C# podemos criar um objeto da classe derivada a partir da sua classe base? Explique e de um exemplo de código.\n");
Console.WriteLine("Não, pois o tentar criar um objeto da classe derivada a partir da classe base, O processo será encerrado devido a um StackOverflow\n ");

Filha ofilha = new Filha();
class Pai
{
    Filha ofilha = new Filha();
    public Pai()
    {
        Console.WriteLine("Construtor Pai");
    }
}
class Filha : Pai
{
    public Filha()
    {
        Console.WriteLine("Construtor Filha");
    }
}
