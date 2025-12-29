namespace PracticaPatronStrategy.Service
{
    public class EnvioExpress : IEnvioStrategy
    {
        public decimal CalcularCosto()
        {
            return 3000;
        }
    }
}
