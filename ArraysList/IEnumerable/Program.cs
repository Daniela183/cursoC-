//aula 120
Console.WriteLine("List<T> x IEnumerable\n");

var limiteCredito = new List<Limite>();

for (int i = 0; i < 10; i++)
{
    limiteCredito.Add(new Limite() { Numero = i });
}

//var limitesComRestricao = limiteCredito.Where(x => x.AnalisaLimite()); //Coleção IEnumerable
var limitesComRestricao = limiteCredito.Where(x => x.AnalisaLimite()).ToList(); //Coleção List

var primeiroLimiteComRestricao = limitesComRestricao.FirstOrDefault();
Console.WriteLine($"\n{primeiroLimiteComRestricao?.Numero}");
//Condições
//if (limitesComRestricao.Count() > 3)
//{
//    Console.WriteLine("\nTemos mais de 3 limites com restrição");
//    //código
//}
//if (limitesComRestricao.Count() > 5)
//{
//    Console.WriteLine("\nTemos mais de 3 limites com restrição");
//}
Console.WriteLine("\nFim do processo");

Console.ReadKey();
public class Limite
{
    public int Numero { get; set; }
    private bool isRestricao;
    public Limite() 
    { 
        var semente = Guid.NewGuid().GetHashCode();
        var numeroAleatorio = new Random(semente).Next(1, 4);
        isRestricao = numeroAleatorio == 1;
    }
    public bool AnalisaLimite()
    {
        Console.WriteLine($"Executa análise de limite de crédito para o limite: {Numero}");
        return isRestricao;
    }
}