
Console.WriteLine("Exercício 05\n");
Console.WriteLine("Para este exercício temos :\r\n1- A classe abstrata Database\r\n2- A classe concreta SQLServer que herda da classe Database" +
    "Quais alterações podemos fazer para que ele possa chamar o método Conectar da classe SQL Server sem alterar o código na classe Program (Método Main)\n");

Console.WriteLine("Resposta:");
Console.WriteLine("O método connect da classe SQLServer deve ser sobrescrito. Como o método Conectar da classe base abstrata é virtual, ele pode ser " +
    "substituído na classe derivada. Ex: public override void Conectar()\r\n");

Console.ReadKey();
abstract class Database
{
    public virtual void Conectar()
    {
        Console.WriteLine("Conectando ao banco de dados...");
    }
    public abstract void Configurar();
}

