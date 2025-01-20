//aula 71
using System.Threading.Channels;

Console.WriteLine("Sobrecarga e Assinatura de Métodos\n");

Email email = new();
email.Enviar("empresa.com.br ");
email.Enviar("empresa.com.br ", "Proposta comercial");
email.Enviar("empresa.com.br ", 2000);
email.Enviar(2000, "empresa.com.br ");

Console.ReadKey();

public class Email
{
    public void Enviar(string endereco)
    {
        Console.WriteLine("---Forma 01---");
        Console.Write($"{endereco}");
        Console.Write("Assunto Padrão");
        Console.WriteLine();
    }
    public void Enviar(string endereco, string assunto)
    {
        Console.WriteLine();
        Console.WriteLine("---Forma 02---");
        Console.Write($"{endereco}");
        Console.Write($"{assunto}");
       
    }
    public void Enviar(string endereco, decimal valor)
    {
        Console.WriteLine();
        Console.WriteLine("\n---Forma 03---");
        Console.Write($"{endereco}");
        Console.Write("Proposta Comercial ");
        Console.Write($"{valor}");
       
    }
    public void Enviar(decimal valor, string endereco)
    {
        Console.WriteLine();
        Console.WriteLine("\n---Forma 04---");
        Console.Write($"{endereco}");
        Console.Write("Pagamento Fornecedor ");
        Console.Write($"{valor}");
    }
}