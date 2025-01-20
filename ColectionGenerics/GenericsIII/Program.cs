//aula 151-152
using System.Collections;

Console.WriteLine("    Generics III");
Console.WriteLine(" Exercício-Generics\n");

ClasseGenerica<int> intObj = new ClasseGenerica<int>();

//Adiciona valores inteiros na coleção
intObj.Adicionar(10);
intObj.Adicionar(20);
intObj.Adicionar(30);
intObj.Adicionar(40);
intObj.Adicionar(50);

Console.WriteLine("Classe ClasseGenerica<M> de objetos int");
//Exibe os valores
for (int i = 0; i < 5; i++)
Console.WriteLine(intObj[i]);

Console.ReadKey();
public class ClasseGenerica<T>
{
    //Definição do array com 5 elementos
    T[] obj = new T[5];
    int contador = 0;
    //Adicionar elementos
    public void Adicionar(T item)
    {
        if (contador < 5)
        {
            obj[contador] = item;
        }
        contador++;
    }
    //Indexador para a iteração da instrução for
    public T this[int index]
    {
        get { return obj[index]; }
        set { obj[index] = value; }
    }
}