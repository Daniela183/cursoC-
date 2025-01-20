// aula 81
Console.WriteLine("Métodos Estáticos\n");

//Sem o método estático
//Calculadora calc = new()
//var soma = calc.Somar(10, 10);
//var subtrair = calc.Subtrair(10, 10);
//var multiplicar = calc.Multiplicar(10, 10);
//var dividir = calc.Dividir(10, 10);

//Com o método estático
var soma = Calculadora.Somar(10, 10);
var subtrair = Calculadora.Subtrair(10, 10);
var multiplicar = Calculadora.Multiplicar(10, 10);
var dividir = Calculadora.Dividir(10, 10);

Console.WriteLine(soma);
Console.WriteLine(subtrair);
Console.WriteLine(multiplicar);
Console.WriteLine(dividir);

Console.ReadKey();

public class Calculadora
{
    public static int Somar(int n1, int n2)
    {
        return n1 + n2;
    }
    public static int Subtrair(int n1, int n2)
    {
        return n1 - n2;
    }
    public static int Multiplicar(int n1, int n2)
    {
        return n1 * n2;
    }
    public static int Dividir(int n1, int n2)
    {
        return n1 / n2;
    }
}