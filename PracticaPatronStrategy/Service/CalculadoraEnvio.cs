namespace PracticaPatronStrategy.Service
{
    public class CalculadoraEnvio
    {
        private readonly IEnvioStrategy _envioStrategy;

        public CalculadoraEnvio(IEnvioStrategy envioStrategy)
        {
            _envioStrategy = envioStrategy;
        }

        public decimal Calcular()
        {
            return _envioStrategy.CalcularCosto();
        }

    }
}
