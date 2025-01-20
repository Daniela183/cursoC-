//aula 64
Console.WriteLine("Métodos: passando parâmetros entre classes\n");

//var aluno = new Aluno();
//Console.Write("Nome: ");
//aluno.Nome = Console.ReadLine();
//Console.Write("Idade: ");
//aluno.Idade = Convert.ToInt32(Console.ReadLine());
//Console.Write("Sexo: ");
//aluno.Sexo = Console.ReadLine();
//Console.Write("Aprovado (S)im (N)ão: ");
//aluno.Aprovado = Console.ReadLine();
//Curso curso = new();
//curso.Resultado(aluno);

Aluno aluno = new();
aluno.Consultar();

Console.ReadKey();

public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    //Jeito de melhorar o cód
    public void Consultar()
    {
        var aluno = new Aluno();

        Console.Write("Nome: ");
        aluno.Nome = Console.ReadLine();

        Console.Write("Idade: ");
        aluno.Idade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Sexo: ");
        aluno.Sexo = Console.ReadLine();

        Console.Write("Aprovado (S)im (N)ão: ");
        aluno.Aprovado = Console.ReadLine();

        Curso curso = new();
        curso.Resultado(aluno);
    }
}
public class Curso
{
    public void Resultado(Aluno aluno)
    {
        Console.Write($"\nO aluno {aluno.Nome}, sexo {aluno.Sexo} com {aluno.Idade} anos");
        if (aluno.Aprovado == "S")
            Console.Write(" foi Aprovado!");
        else
            Console.Write(" foi Reprovado!");
    }
}

