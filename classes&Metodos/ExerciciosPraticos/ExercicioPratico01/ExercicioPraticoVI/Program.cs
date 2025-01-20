//aula 84
Console.WriteLine("Exercício Prático VI");
public class Carro
{
    public static double ValorIpva;
    public static void ObterValorIPVA()
    {
        ValorIpva = 4;
    
    Console.WriteLine("Chamando o método estático ObterValorIPVA: ");
    Carro.ObterValorIPVA();
    Console.WriteLine("Valor do campo ValorIpva: " + Carro.ValorIpva + "%");
    }
}
