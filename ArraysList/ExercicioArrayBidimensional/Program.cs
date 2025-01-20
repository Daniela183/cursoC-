//aula 110
Console.WriteLine("Exercicio - Array Bidimensional\n");

//Declarando e alocando memória 
string[,] aluno = new string[2, 5];

Console.WriteLine("Atribuindo dados a um array de strings com 2 linhas e 5 colunas [2,5]\n");

Console.WriteLine("{Maria, Paulo, Marta, Pedro, Carlos}");

Console.WriteLine("{Silvia, Pedro, Alicia, Manoel, Paula}\n");

//Recebendo os nomes via teclado
for (int i = 0; i < aluno.GetLength(0); i++) //Número de linhas
{
    for (int j = 0; j < aluno.GetLength(1); j++) //Número de colunas
    {
        Console.Write($"Informe o valor para o elemento na posição [{i},{j}]: ");
        aluno[i, j] = Console.ReadLine();
    }
}

Console.WriteLine("\nConteúdo do Array criado \n");

//Exibindo os nomes atribuidos ao array
for (int i = 0; i < aluno.GetLength(0); i++)
{
    for (int j = 0; j < aluno.GetLength(1); j++)
    {
        Console.Write($"[{i},{j}] = {aluno[i, j]}\t ");
    }
    Console.WriteLine("");
}

Console.ReadKey();

