//aula 69
Console.WriteLine("Métodos com Retorno\n");

Calculadora calc = new();
var valor = calc.Soma(10, 10);
Console.WriteLine(valor);
Console.WriteLine(calc.Soma(10,10));

Console.ReadKey();
public class Calculadora
{
    public int Soma(int n1, int n2)
    {
        return n1 + n2; 
    }
    public int Subtração(int n1, int n2)
    {
        return n1 - n2;
    }
    public int Multiplicacao(int n1, int n2)
    {
        return n1 * n2;
    }
    public int Divisao(int n1, int n2)
    {
        return n1 / n2;
    }
}