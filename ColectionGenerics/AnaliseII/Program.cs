//aula 151
using System.Collections;

Console.WriteLine("Análise II\n");

ArrayList obj = new ArrayList();

//boxing - converter o tipo por valor para tipo por referência
obj.Add(50);

int x = (int)obj[0];   //realiza o unboxing

foreach (int i in obj)
{
    Console.WriteLine(i);   //realiza unboxing
}
Console.ReadKey();