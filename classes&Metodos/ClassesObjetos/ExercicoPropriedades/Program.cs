//aula 87
Console.WriteLine("Exercício - Propriedades\n");

Produto p1 = new();
p1.Nome = "Caderno Espiral\n";
p1.Preco = 4.99;
p1.EstoqueMinimo = 10;

p1.Exibir();

Console.ReadKey();

public class Produto
{
    //Como funciona as propriedades
    private string? nome;
    public string? Nome
    {
        get { return nome.ToUpper(); }
        set { nome = value; }
    }

    private double preco;
    public double Preco
    {
        get { return preco; }
        set
        {
            if (value < 5.00)
                preco = 5.00;
            else
                preco = value;
        }
    }

    private double desconto = 0.05;
    public double Desconto
    {
        get { return desconto; }
    }

    public double PrecoFinal
    {
        get { return Preco - (Preco * Desconto); }
    }

    private int minimo;
    public int EstoqueMinimo
    {
        set { minimo = value; }
    }

    public void Exibir()
    {
        Console.WriteLine($"{Nome} \nPreço: {Preco.ToString("c")} \nDesconto: {Desconto}" +
                          $" \nPreço Final: {PrecoFinal.ToString("c")} \nQantidade em estoque: {minimo}");
    }
}


//Produto p1 = new();
//p1.Nome = "Caderno Espiral";
//p1.Preco = 4.99;
//p1.Desconto = 0.05; fica sendo somente leitura
//p1.PrecoFinal = p1.Preco - p1.Preco * p1.Desconto; fica sendo somente leitura
//p1.EstoqueMinimo = 10;

//p1.Exibir();

//Forma de propriedade
//public class Produto
//{
//    public string? Nome { get; set; }
//    public double Preco { get; set; }
//    public double Desconto { get; set; }
//    public double PrecoFinal { get; set; }
//    public int EstoqueMinimo { get; set; }

//    public void Exibir()
//    {
//        Console.WriteLine($"{Nome} \n{Preco.ToString("c")} \n{Desconto}" +
//                         $" \n{PrecoFinal.ToString("c")} \n{minimo}");
//    }
//}