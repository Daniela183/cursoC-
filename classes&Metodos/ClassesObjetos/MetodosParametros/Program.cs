//aula 63
Console.WriteLine("Métodos: passando parâmetros\n");

MinhaClasse minhaClasse = new MinhaClasse();

var nomeCliente = "Maria";
var dataAtual = DateTime.Now.ToShortDateString();

//Valores dos argumentos
minhaClasse.Saudacao(nomeCliente, dataAtual);

Console.ReadKey();

public class MinhaClasse
{
//Parâmetros do método
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);

        Console.Write(nome + " ");
        Console.Write(data);
    }
}
