using Microsoft.Extensions.DependencyInjection;

namespace MissingCoverage.Host
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
