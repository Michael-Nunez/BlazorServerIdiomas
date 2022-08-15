using System.Globalization;

namespace BlazorServerIdiomas.Helpers
{
    public static class Constantes
    {
        public static CultureInfo[] CulturasSoportadas = new[]
             {
                new CultureInfo("en-US"),
                new CultureInfo("es-US"),
                new CultureInfo("es-DO"),
                new CultureInfo("es"),
                new CultureInfo("en")
            };
    }
}
