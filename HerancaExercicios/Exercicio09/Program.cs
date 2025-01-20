
Console.WriteLine("Exercício 09\n");
Console.WriteLine("Apresente um cenário onde a utilização de interfaces seria a única solução possível. Explique e dê um exemplo de código.Um cenário onde " +
    "o uso de interfaces é a única solução possível seria um cenário onde temos que uma classe precisa herdar de mais de uma classe ou interface, " +
    "caracterizando a herança múltipla de interface.Na linguagem C# uma classe não pode herdar de mais de uma classe porém pode herdar de várias " +
    "interfaces. Neste caso o uso de interfaces seria indispensável.\n");
Console.WriteLine("A classe MastroCreditCart precisar implementar a validação do cartão e a inicialização da transação que devem ser definidos em classes" +
    " ou interfaces diferentes, e com isso vai precisar herdar das duas classes ou interfaces. Como não podemos herdar de duas classes a solução" +
    " é criar duas interfaces (ou uma classe e uma interface) e fazer com que a classe MastroCreditCard herde das duas interfaces " +
    "(ou herde da classe e implemente a interface).\r\n");

MastroCreditCard cartao = new MastroCreditCard();
cartao.ValidarCartao();
cartao.IniciarTransacao();
cartao.StatusTransacao();
Console.ReadKey();
interface ICartaoCredito
{
    void ValidarCartao();
}
interface ITransacao
{
    void IniciarTransacao();
}
class MastroCreditCard : ICartaoCredito, ITransacao
{
    public void ValidarCartao()
    {
        Console.WriteLine("Validando cartão...");
    }
    public void IniciarTransacao()
    {
        Console.WriteLine("Iniciando transação...");
    }
    public void StatusTransacao()
    {
        Console.WriteLine("Transação Completada");
    }
}