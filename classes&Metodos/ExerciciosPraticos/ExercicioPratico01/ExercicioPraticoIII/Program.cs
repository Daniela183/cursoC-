//aula 75
Console.WriteLine("Exercício Prático III");

public class Carro
{
    //Letra i
    public int AumentarPotencia(int potencia)
    {
        potencia += 3;
        return potencia;

        Console.WriteLine("Aumentando a Potencia (por valor: + 3CV): ");

        var novaPotenciaChevrolet = chevrolet.AumentarPotencia(chevrolet.Potencia);
        Console.Write("-> " + novaPotenciaChevrolet);
        Console.WriteLine("\nO valor do campo Potencia não foi alterado: " + chevrolet.Potencia);
    }

    //Letra p
    public int AumentarPotencia(ref int potencia)
    {
        potencia += 5;
        return potencia;
    

    Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120, 5);

    Console.Write("\nAumentando a Potencia (por referência: + 5CV): ");

    var novaPotenciaFord = ford.AumentarPotencia(ref ford.Potencia);
    Console.Write("-> " + novaPotenciaFord);
    Console.WriteLine("\nO valor do campo Potencia foi alterado: " + ford.Potencia);
    }
}