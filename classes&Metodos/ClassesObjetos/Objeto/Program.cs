//aula 61
Console.WriteLine("O que é Objeto\n");

//Objeto
Pessoa p1 = new(); 
p1.nome = "Maria";
p1.idade = 25;
p1.sexo = "feminino";

Console.WriteLine($"{p1.nome} {p1.idade} anos, sexo {p1.sexo}");

Console.ReadKey();

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}
