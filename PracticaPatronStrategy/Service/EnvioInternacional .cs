namespace PracticaPatronStrategy.Service
{
    public class EnvioInternacional : IEnvioStrategy
    {
        public decimal CalcularCosto()
        {
            return 5000;
        }
    }
}
