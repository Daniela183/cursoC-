// aula 251 C# 12
using ListaItens = System.Collections.Generic.List<string>;
using Trasacao = (decimal Valor, System.DateTime Data, TipoTransacao Tipo);
Console.WriteLine("Novos Recursos\n");

ListaItens lista = new ListaItens();

lista.Add("item 1");
lista.Add("item 2");
lista.Add("item 3");

foreach (var item in lista)
{
    Console.WriteLine(item);
}

List<Trasacao> transacoes = new List<Trasacao>()
{
    (100.00M, DateTime.Now, TipoTransacao.Deposito),
    (50.00M, DateTime.Now.AddDays(-1), TipoTransacao.Saque),
    (200.00M, DateTime.Now.AddDays(-2), TipoTransacao.Tranferencia),
    (75.00M, DateTime.Now.AddDays(-3), TipoTransacao.Deposito),
};
Console.WriteLine("\nLista de Transações: \n");

foreach (var item in transacoes)
{
    Console.WriteLine($"Valor: {item.Valor:C}," +
        $" Data: {item.Data}, " +
        $"Tipo: {item.Tipo}\n");
}

Console.WriteLine("\nSpread\n");

int[] numeros = [1, 2, 3, 4, 5];

foreach (var item in numeros)
{
    Console.Write($"{item} ");
}

Span<string> RegiaoSul = ["PR", "SC", "RS"];

ReadOnlySpan<string> RegiaoSudeste = ["ES", "MG", "RJ", "SP"];

List<string> frutas1 = ["\nAmora", "Banana", "Caju"];
List<string> frutas2 = ["Damasco", "Embaúba"];
List<string> listaCombinada = [.. frutas1 ,.. frutas2 ];

foreach (string item in listaCombinada)
    Console.Write($"{item} ");

Console.WriteLine("\n\nExpressão lambda\n");

List<Produto> produtos = new List<Produto>
{
    new Produto("Produto A", 10.99M),
    new Produto("Produto B", 15.99M),
    new Produto("Produto C", 5.99M),
    new Produto("Produto D", 20.99M),
    new Produto("Produto E", 1.99M),
};

var filtarPrecoMinimo = (decimal precoMinimo = 0.0M) =>
{
    return produtos.FindAll(produtos => produtos.Preco >= precoMinimo);
};
Console.WriteLine("Produtos com preço mínimo de 10.00");
foreach (var produto in filtarPrecoMinimo(10.00M))
{
    Console.WriteLine($"{produto.Nome} - Preço: {produto.Preco:C}");
}
Console.WriteLine("\nTodos os produtos sem filtro");
foreach (var produto in filtarPrecoMinimo())
{
    Console.WriteLine($"{produto.Nome} - Preço: {produto.Preco:C}");
}
Console.ReadKey();

public enum TipoTransacao
{
    Deposito, Saque, Tranferencia
}

public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }
}