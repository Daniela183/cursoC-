//aula 62
Console.WriteLine("Métodos\n");

MinhaClasse minhaClasse = new MinhaClasse();

minhaClasse.Saudacao();
//minhaClasse.ExibirDataAtual();

Console.ReadKey();

class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Bem vindo!");
        ExibirDataAtual();
        Console.WriteLine("10/06/2024");
    }
    public void ExibirDataAtual() =>
        Console.WriteLine(DateTime.Now.ToShortDateString());
    
}