
using Exercicio10;

Console.WriteLine("Exercício 10\n");
Console.WriteLine("Usando os conceitos de polimorfismo escreva um programa para calcular a área do Quadrado, Triângulo e do Circulo\r\nFórmulas das áreas" +
    "\r\n- Quadrado -> A = lado * lado \r\n- Triângulo -> A = (base * altura)/2\r\n- Circulo -> A = Pi * raio * raio ou A = π . r²\r\n");

Forma c = new Circulo(3.5);
Console.WriteLine($"Área do círculo 3.5 A = { c.Area()}");
Forma q = new Quadrado(5.5);
Console.WriteLine("Área do quadrado 5.5 = {0}", q.Area());
Forma t = new Triangulo(3.0, 5.0);
Console.WriteLine("Área do triângulo 3.0 x 5.0 = {0}", t.Area());
Console.ReadKey();

var formas = new List<Forma>()
{
new Circulo(3.5),
new Quadrado(5.5),
new Triangulo(3.0,5.0)
};
foreach (var forma in formas)
{
    Console.WriteLine(forma.Area());
}
Console.ReadKey();