//aula 79
Console.WriteLine("Parâmetros Opcionais\n");

Console.Write("Informe o destino: ");
var destino = Console.ReadLine();

Console.Write("Informe o titulo: ");
var titulo = Console.ReadLine();

Console.Write("Informe o assunto: ");
var assunto = Console.ReadLine();

Email email = new();

email.Enviar();
email.Enviar(destino);
email.Enviar(destino, titulo);
email.Enviar(destino, titulo, assunto);

//Não pode fazer assim, pois da um erro
//email.Enviar(destino, , assunto);
Console.WriteLine("\n---Alternativa---");
email.Enviar(destino, assunto: assunto);

Console.ReadKey();

public class Email
{
    public void Enviar(string destino = "Destino padrão", string titulo = "Titulo Padrão", string assunto = "Assunto Padrão")
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}