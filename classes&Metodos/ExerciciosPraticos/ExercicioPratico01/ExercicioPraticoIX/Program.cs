//aula 93
Console.WriteLine("Exercício Prático IX\n");

public class Carro
{
    //campo 
    public int Cor;
    //construtor 
    public Carro(string? Modelo, string? Montadora, string? Marca,
    int Ano, int Potencia, int cor)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
        Cor = cor;
    }
    //método 
    public void ExibirInfo(string? Modelo, string? Montadora, string? Marca,
    int Potencia, int Cor = 1, int Ano = 2022)
    {
        Console.WriteLine(Modelo);
        Console.WriteLine(Montadora);
        Console.WriteLine(Marca);
        Console.WriteLine(Potencia);
        Console.WriteLine(Ano);
        Console.WriteLine((Cores)Cor);
    }
    Console.WriteLine($"{Cores.Branco} - {(int)Cores.Branco}");
Console.WriteLine($"{Cores.Vermelho} - {(int)Cores.Vermelho}");
Console.WriteLine($"{Cores.Preto} - {(int)Cores.Preto}");
Console.WriteLine($"{Cores.Cinza} - {(int)Cores.Cinza}");
Console.WriteLine($"{Cores.Prata} - {(int)Cores.Prata}");
Console.WriteLine($"{Cores.Azul} - {(int)Cores.Azul}");
Console.WriteLine("\nSelecione a Cor do carro");
int cor = Convert.ToInt32(Console.ReadLine());
    //chevrolet
    Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110, cor);
    chevrolet.Acelerar(chevrolet.Marca);
chevrolet.ExibirInfo(chevrolet.Modelo, chevrolet.Montador
 }