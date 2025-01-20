//aula 67
Console.WriteLine("This\n");


//public class Cliente
//{
//    public string? Nome;
//    public int Idade;

//    public Cliente(string? Nome, int Idade)
//    {
//        this.Nome = Nome;
//        this.Idade = Idade;
//    }
//}
//Teste t1 = new Teste();
//t1.Num1 = 10;
//t1.Num2 = 20;
//t1.Exibir();

//Teste t2 = new Teste();
//t2.Num1 = 88;
//t2.Num2 = 90;
//t2.Exibir();

Teste t1 = new Teste(999);
Console.ReadKey();

public class Teste
{
    public Teste(int Num1,int Num2)
    {
        Console.WriteLine($"\nConstrutor com dois parâmetros {Num1} e {Num2}");
    }
    public Teste(int num) : this(777, 888)
    {
        Console.WriteLine("\nConstrutor com um parâmetro " + num);
    }
}

//public class Teste
//{
//    public int Num1;
//    public int Num2;

//    public void PassarParam(Teste t)
//    {
//        Console.WriteLine($"\nthis = {this}");
//        Console.WriteLine("Num1: " + t.Num1);
//        Console.WriteLine("Num2: " + t.Num2);
//    }
//    public void Exibir()
//    {
//        //Passando o this como um parâmentro da classe teste 
//        PassarParam(this);
//    }
//}
