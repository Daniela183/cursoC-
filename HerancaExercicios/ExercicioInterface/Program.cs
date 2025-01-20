//aula 141
using ExercicioInterface;

Console.WriteLine("Exercício Interfaces\n");

SalvarXml salvarXml = new SalvarXml();
salvarXml.Salvar();
salvarXml.Nome();

Console.WriteLine();

SalvarJson salvarJson = new SalvarJson();
salvarJson.Salvar();
salvarJson.Nome();

Console.WriteLine();

ISalvar salvarArq = new SalvarJson();
salvarArq.Compactar();

Console.ReadKey();