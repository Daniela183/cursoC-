//aula 77
Console.WriteLine("Exercício Prático IV");

    public class AumentarVelocidade 
{ 
    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
        {
            potencia += 7;
            velocidade = potencia * 1.75;
            return potencia;
    }

    Console.WriteLine("\nUsando parâmetro out => Aumenta potência e velocidade ");
     double novaPotencia = chevrolet.AumentarPotenciaVelocidade(chevrolet.Potencia, out double velocidade);
     Console.WriteLine("-Nova Potência: " + novaPotencia);
     Console.WriteLine("-Nova Velocidade Máxima: " + velocidade);
    
}
