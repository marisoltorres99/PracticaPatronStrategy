using PracticaPatronStrategy.Service;

public class Program
{
    static void Main(string[] args)
    {
        var calculadora = new CalculadoraEnvio(new EnvioExpress());
        Console.WriteLine($"Costo del envío: {calculadora.Calcular()}");
    }
}