namespace PracticaPatronStrategy.Service
{
    public class EnvioNormal : IEnvioStrategy
    {
        public decimal CalcularCosto()
        {
            return 1500;
        }
    }
}
