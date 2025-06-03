namespace DesafioPratico01;
internal class Calculos(double valor1, double valor2)
{
    public double Somar() => valor1 + valor2;
    public double Subtrair() => valor1 - valor2;
    public double Multiplicar() => valor1 * valor2;
    public double Dividir()
    {
        if (valor1.Equals(0) || valor2.Equals(0))
        {
            Console.WriteLine("Não é possível fazer divisão por 0!!");
            return 0;
        }
        
        return valor1 / valor2;
    }
}
