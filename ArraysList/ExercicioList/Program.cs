//aula 121
using ExercicioList;

Console.WriteLine("List<T> - Exercício");

List<Aluno> alunos = FonteDados.GetAlunos();

ExibirAlunos(alunos);
//2
Aluno bia = new Aluno() { Nome = "Bia", Nota = 7.75};
Aluno mario = new Aluno() { Nome = "Mario", Nota = 8.95};
alunos.Add(bia);
alunos.Add(mario);

ExibirAlunos(alunos);
//3
var aluno1 = alunos.Find(n => n.Nome.Equals("Amanda"));
alunos.Remove(aluno1);

ExibirAlunos(alunos);

//4
var listaOrdenada = alunos.OrderBy(n => n.Nome).ToList();

ExibirAlunos(listaOrdenada);

//5
var alunosNotaOito = alunos.FindAll(n => n.Nota >= 8).OrderBy(n => n.Nome).ToList(); ;
Console.WriteLine("\n---Alunos com nota maior que oito---\n");

foreach (var item in alunosNotaOito)
{
    Console.WriteLine($"{item.Nome} \t{item.Nota} ");
}

Console.ReadKey();
//1
static void ExibirAlunos(List<Aluno> alunos)
{
   
    Console.WriteLine("\n---Relação de alunos---");
    Console.WriteLine("\nNome \tNota");

    var somaNotas = 0.0;
    foreach (var item in alunos)
    {
        Console.WriteLine($"{item.Nome} \t{item.Nota} ");
        somaNotas += item.Nota;
    }
    var mediaNotas = somaNotas / alunos.Count();
    Console.WriteLine($"\nMédia das notas: {Math.Round(mediaNotas, 2)}");
    Console.WriteLine($"Total de alunos: {alunos.Count()}");
}