//aula 85
public class Pessoa
{
    public static int IdadeMinima;

    public int Idade { get; set; }
    public string Nome { get; set; } = string.Empty;

    public Pessoa(int idade, string nome)
    {
        Console.WriteLine("\nExecutando o construtor parametrizado");
        Idade = idade;
        Nome = nome;
    }

    public Pessoa()
    { }
    //Costrutor estático, se não inicializar ele inicializa com o valor padrão
    static Pessoa()
    {
        Console.WriteLine("\nExecutando o construtor estático");
        Console.WriteLine("\nInicializando o campo Idade Mínima");
        IdadeMinima = 18;
    }
}
