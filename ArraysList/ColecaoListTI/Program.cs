//aula 115
Console.WriteLine("List <T> I\n");

//Não ha nada para compilar, somente mostrando como funciona
//Declarando uma coleção do tipo List<T>
List<string> lista;
lista = new List<string>();

List<int> lista1 = new List<int>();
var lista2 = new List<float>();
List<double> lista3 = new();

//Incluindo elementos
List<string> nomes = new();
nomes.Add("Paulo");
nomes.Add("Maria");

var lista4 = new List<string>()
{
    "Paulo", "Maria", "Bia", "Pedro"
};

Console.ReadKey();