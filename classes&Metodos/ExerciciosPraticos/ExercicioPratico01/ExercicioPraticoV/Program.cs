//aula 80
Console.WriteLine("Exercício Prático V");

public class Exibicao
{
    public void ExibirInfo(string? Modelo, string? Montadora, string? Marca, int Potencia, int Ano = 2022)
    {
        Console.WriteLine(Modelo);
        Console.WriteLine(Montadora);
        Console.WriteLine(Marca);
        Console.WriteLine(Potencia);
        Console.WriteLine(Ano);
    
    Console.WriteLine("\nUsando argumentos nomeados e parâmetros opcionais \n");
    Console.WriteLine("Sem informar o parâmetro opcional Ano");
    ford.ExibirInfo(Modelo: ford.Modelo, Montadora: ford.Montadora, 
    Marca: ford.Marca, Potencia: ford.Potencia);
    Console.WriteLine("\nInformando o parâmetro opcional Ano");
    ford.ExibirInfo(Modelo: ford.Modelo, Montadora: ford.Montadora,
    Marca: ford.Marca, Potencia: ford.Potencia, Ano: ford.Ano);
    }
}