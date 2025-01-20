//aula 70
Console.WriteLine("Exercício Prático II\n");
Console.WriteLine("g- Crie um construtor que permita criar um carro somente usando os atributos: Modelo e Montadora(não use a palavra-chave this)" +
    "\r\ni- Crie um método chamado VelocidadeMaxima que recebe um parâmetro do tipo int chamado potencia que vai retornar um double representando a " +
    "velocidade máxima do carro( Para calcular a velocidade multiplique a potencia por 1.75)");
public class Carro
{
    public string? Modelo;
    public string? Montadora;

    // Construtor
    public Carro(string? modelo, string? montadora)
    {
       Modelo = modelo;
       Montadora = montadora;
      
    }
    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }
}
