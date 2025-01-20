//aula 60
Console.WriteLine("Alocação de Memória\n");

Pessoa p1 = new Pessoa();
p1.nome = "Maria";
p1.idade = 25;
p1.sexo = "feminino";

Console.WriteLine($"{p1.nome} {p1.idade} anos, sexo {p1.sexo}");

Pessoa p2 = p1;

Console.WriteLine($"{p2.nome} {p2.idade} anos, sexo {p2.sexo}");

Console.ReadKey();
class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}
