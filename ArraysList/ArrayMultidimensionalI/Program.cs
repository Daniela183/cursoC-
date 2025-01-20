//aula 108
Console.WriteLine("Array Multidimensional I\n");

//Declaração
int[,] a;

//Instância 
a = new int[2, 2];

//Atribuição de valores
a[0, 0] = 10;
a[0, 1] = 11;
a[1, 0] = 12;
a[1, 1] = 13;


Console.WriteLine("\nArray a\n");

//Exibe os valores do array
Console.WriteLine(a[0, 0]);
Console.WriteLine(a[0, 1]);
Console.WriteLine(a[1, 0]);
Console.WriteLine(a[1, 1]);

Console.WriteLine("\nArray b\n");

//Declaração, inicialização e atribuição
//int[,] b = new int[2, 2] { {20,30 }, {40,50 } };

//Declaração simplificada
int[,] b = { { 20, 30 }, { 40, 50 } };

Console.WriteLine(b[0, 0]);
Console.WriteLine(b[0, 1]);
Console.WriteLine(b[1, 0]);
Console.WriteLine(b[1, 1]);

Console.ReadKey();


