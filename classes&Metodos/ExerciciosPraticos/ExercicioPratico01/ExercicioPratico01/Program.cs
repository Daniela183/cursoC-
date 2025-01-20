//aula 68
//using System.Net;
//using System.Reflection;
//using System;


using System;

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    // Construtor
    public Carro(string? modelo, string? montadora, string? marca, int ano, int potencia)
    {
        this.Modelo = modelo;
        this.Montadora = montadora;
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia = potencia;
    }

    // Método Acelerar
    public void Acelerar(string marca)
    {
        Console.WriteLine("Acelerando o meu " + marca);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instruções para o usuário
        Console.WriteLine("Exercício Prático I");
        Console.WriteLine("1- Em um projeto console crie uma classe Carro contendo os atributos : modelo, montadora, marca, ano e potencia com os tipos de dados string, string, " +
            "string, int e int.\r\nCrie também o comportamento Acelerar que não retorna nada e apenas exiba a mensagem “Acelerando...”\n\n" +
            "a- Crie um objeto chevrolet e atribua os seguintes valores aos atributos : Sedan, Chevrolet , Onix, 2016, 110 \nb- Crie outro objeto ford e atribua os seguintes valores aos" +
            " atributos: SUV, Ford, EcoSport, 2018, 120" +
            "\nc- Exiba os valores dos atributos no console para cada um dos objetos criados e chame o método Acelerar para cada objeto\r\nd- Altere o método Acelerar para receber um " +
            "parâmetro do tipo string chamado marca e a seguir altere a mensagem para exibir o texto “Acelerando o meu {marca}“, seguido da marca do carro." +
            "\ne- Crie um construtor na classe Carro que vai permitir criar objetos inicializando os valores dos atributos: modelo, montadora, marco, ano e potencia (use a palavra this" +
            " para identificar a instância da classe)\r\nf- Crie novamente os objetos carro1 e carro2 com os mesmos valores usando o construtor acima e invoque o método Acelerar " +
            "passando o valor do argumento para o parâmetro no método Acelerar" +
            "\nObs- Utilize a nomenclatura Pascal Case para definir os nomes e o modificador de acesso public para todos os membros da class\n\n");
      
        // Criação do objeto chevrolet
        Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);

        // Exibição dos valores dos atributos do objeto chevrolet
        Console.WriteLine($"{chevrolet.Modelo} {chevrolet.Montadora} {chevrolet.Marca} {chevrolet.Ano} {chevrolet.Potencia} CV");
        
        // Chamada ao método Acelerar para o objeto chevrolet
        chevrolet.Acelerar(chevrolet.Marca);

        // Criação do objeto ford
        Carro ford = new Carro("\nSUV", "Ford", "EcoSport", 2018, 120);

        // Exibição dos valores dos atributos do objeto ford
        Console.WriteLine($"{ford.Modelo} {ford.Montadora} {ford.Marca} {ford.Ano} {ford.Potencia} CV");
        
        // Chamada ao método Acelerar para o objeto ford
        ford.Acelerar(ford.Marca);
        Console.ReadKey();
    }
}
