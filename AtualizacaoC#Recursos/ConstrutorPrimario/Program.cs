// aula 252 C# 12
Console.WriteLine("Construtor Primário\n");

var aluno = new Aluno("Maria", "Silveira", 9);
var aluno1 = new Aluno2("Maria", "Silveira", 9);
var aluno2 = new Aluno(7);

Console.WriteLine($"{aluno.NomeCompleto} Nota: {aluno.Nota}");
Console.WriteLine($"{aluno1.NomeCompleto} Nota: {aluno1.Nota}");

Console.ReadKey();
public class Aluno(string nome, string sobrenome, int nota)
{
    public Aluno() : this("Marta", "Bueno", 8) { }
    public Aluno(int nota) : this("Claudia", "Santos", nota) { }
    public string Nome { get; init; } = nome;
    public string Sobrenome { get; set; } = sobrenome.ToLower();
    public int Nota { get; set; } = nota;
    public string NomeCompleto => $"{Nome} {Sobrenome}";

}

public class Aluno2(string nome, string sobrenome, int nota)
{
    public int Nota { get; set; } = nota;
    public string NomeCompleto => $"{nome} {sobrenome}";

}