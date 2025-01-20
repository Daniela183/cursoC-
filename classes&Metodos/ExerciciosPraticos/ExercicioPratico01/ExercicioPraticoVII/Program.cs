//aula 88
Console.WriteLine("Exercício Prático VII");

private int ano;
public int Ano
{
    get { return ano; }
    set
    {
        if (value < 2000)
            ano = 2000;
        else if (value > 2022)
            ano = 2022;
        else
            ano = value;
    }
}